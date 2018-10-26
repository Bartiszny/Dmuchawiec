/*<summary> Projekt z przedmiotu "Jezyki Programowania Wysokiego Poziomu"
*Gra "Dmuchawiec" na platforme "E-dmuchawka"
*
*<author>Bartlomiej Horiszny</author>
*<version>1.0</version>
 *</summary>
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Gra
{
    /// <summary>
    /// Klasa okna dziedziczaca po WinForm - mechanizmy gry
    /// </summary>
    public partial class Okno : Form
    {   ///<summary>
        ///Inicjalizacja obiektu klasy <c>Dmuchawiec</c>
        /// </summary>
        Dmuchawiec dmuchawiec = new Dmuchawiec(); //----obiekt sterowany
        
        /// <summary>
        /// Inicjalizacja listy obiektow klasy <c>Sciana</c>, 
        /// </summary>
        List<Sciana> scianyNaEkranie = new List<Sciana>();
        
        /// <summary>
        /// Inicjalizacja obiektu klasy <c>GeneratorScian</c>
        /// </summary>
        GeneratorScian generatorScian;
        
        /// <summary>
        /// Inicjalizacja obiektu wypelnienia klasy <c>Graphics</c>
        /// </summary>
        Graphics grafika;
        
        /// <summary>
        /// Inicjalizacja obiektu klasy <c>Stopwatch</c> - stopera
        /// </summary>
        Stopwatch stopWatch = new Stopwatch(); 
        /// <summary>
        /// Deklaracja pola bufora
        /// </summary>
        public double buff = 350;           
        /// <summary>
        /// Deklaracja pole bufora 2
        /// </summary>
        double buff2;                       
        /// <summary>
        /// Deklaracja pola licznika timera
        /// </summary>
        int licznikTimera = 0;
        /// <summary>
        /// Deklaracja pola licznika punktow/odleglosci
        /// </summary>
        int licznikOdleglosci = 0;
        /// <summary>
        /// Deklaraca pola licznika calkowitego czasu dmuchania
        /// </summary>
        int licznikDmuchania = 0;
        /// <summary>
        /// Deklaracja pola licznika poziomow
        /// </summary>
        int licznikPoziomu = 1;
        /// <summary>
        /// Deklaracja pola interwalu przeszkod
        /// </summary>
        int n = 50;
        /// <summary>
        /// Deklaracja pola statusu rozpoczecia gry
        /// </summary>
        bool startGry = false;
        /// <summary>
        /// Deklaracja pola stanu gry
        /// </summary>
        bool start = false;               
        /// <summary>
        /// Konstruktor klasy, inicjalizacna komponentow, klawiszy, timera i jego interwalu 
        /// </summary>
        public Okno()
        {
             
            InitializeComponent();
            this.KeyDown += Space_KeyDown;
            this.KeyUp += Space_KeyUp;
            this.MainTimer.Tick += new EventHandler(MainTimer_Tick);
            this.KeyDown += Esc_KeyPress;
            generatorScian = new GeneratorScian(pole.Height, pole.Width);
            dodajScianeNaEkran();
            MainTimer.Enabled = true;
            MainTimer.Interval = 75;            
        }
      /// <summary>
      /// Metoda reagujaca na zdarzenie rysowania pola gry
      /// </summary>
      /// <param name="sender">Obiekt wysylajacy zdarzenie</param>
      /// <param name="e">Obiekt zawierajacy parametry zdarznia</param>
        private void Pole_Paint(object sender, PaintEventArgs e)
        {
            grafika = e.Graphics;
            grafika.DrawImage(dmuchawiec.Obraz, dmuchawiec.pobierzPozycje());
            foreach (Sciana sciana in scianyNaEkranie)
            {
                sciana.rysuj(grafika);
            }
            
        }
        /// <summary>
        /// Metoda reagujaca na zdarzenie timera - petla programu
        /// </summary>
        /// <param name="sender">Obiekt wysylajacy zdarzenie</param>
        /// <param name="e">Obiekt zawierajacy parametry zdarznia</param>
        private void MainTimer_Tick(object sender, EventArgs e)
        {
           
            if (start)                                                                // warunkowy start
            {
                List<Sciana> scianyDoUsuniecia = new List<Sciana>();
                licznikOdleglosci++;
                this.licznikodlegolosci.Text = licznikOdleglosci.ToString();
                this.licznikpoziomu.Text = licznikPoziomu.ToString();
                licznikTimera++;
                dmuchawiec.opadaj();
               
             
                foreach (var sciana in scianyNaEkranie)         // przesuwanie i usuwanie scian poza ekranem
                {
                    sciana.suwaj();
                    if (sciana.czyPozaEkranem())
                    {
                        scianyDoUsuniecia.Add(sciana);
                    }
                }
                foreach (var sciana in scianyDoUsuniecia)
                {
                    scianyNaEkranie.Remove(sciana);
                }
                
              
                if (licznikTimera == n)                         // interwal pojawiania sie scian
                {
                    dodajScianeNaEkran();
                    licznikTimera = 0;
                }

                pole.Invalidate();
                pole.Update();
              
                start &= dmuchawiec.sprawdzKolizaSufit();              //sprawdzanie kolizji
                start &= dmuchawiec.sprawdzKolizjaPodloga();
                foreach (var sciana in scianyNaEkranie)
                {
                    start &= dmuchawiec.sprawdzKolizjaSciana(sciana);
                }
               
            
                if (licznikOdleglosci == 500)                           // modyfyfikacja poziomow
                {
                    MainTimer.Interval = 50;
                    licznikPoziomu = 2;
                }
                else if (licznikOdleglosci == 1000)
                {
                    MainTimer.Interval = 30;
                    licznikPoziomu = 3;
                }

            }
           
            else if(startGry)                                       //koniec gry
            {
                MainTimer.Stop();
                MainTimer.Dispose();
                this.menuNapis.Text = "GAME \nOVER!";
                
                this.menuPanel.Visible = true;
                this.powrot.Visible = false;
                this.zapisWynikow.Enabled = true;
                this.zakoncz.Enabled = true;
            }
            else 
            {
                MainTimer.Stop();
            }
            }
        /// <summary>
        /// Metoda dodajaca przeszkody na ekran
        /// </summary>
        private void dodajScianeNaEkran()
        {
            var scianaGorna = generatorScian.stworzScianeGorna();
            var scianaDolna = generatorScian.stworzScianeDolna(scianaGorna.Wysokosc);
            scianyNaEkranie.Add(scianaGorna);
            scianyNaEkranie.Add(scianaDolna);
        }                    
        /// <summary>
        /// Metoda reagujaca na zdarznie nacisniecia klawisza spacji - start stopera
        /// </summary>
        /// <param name="sender">Obiekt wysylajacy zdarzenie</param>
        /// <param name="e">Obiekt zawierajacy parametry zdarznia</param>
        public void Space_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                stopWatch.Start();                          
            }
        }
        /// <summary>
        /// Metoda reagujaca na zdarzenie puszczenia klawisza spacji, zatrzymanie stopera, obliczenie dlugosci skoku 
        /// w zaleznosci od zmierzonego czasu i reset stopera
        /// </summary>
        /// <param name="sender">Obiekt wysylajacy zdarzenie</param>
        /// <param name="e">Obiekt zawierajacy parametry zdarznia</param>
        public void Space_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {       
               
                stopWatch.Stop();                                    
                
                licznikDmuchania = (int)stopWatch.ElapsedMilliseconds;      // licznie dlugosci skoku
                buff2 = (int)stopWatch.ElapsedMilliseconds;     
                buff = dmuchawiec.pobierzPozycje().Y;
                buff = buff - (buff2 * 0.25);                      
               
                if (buff < 0)
                {
                    buff = 0;
                }
                if (buff > 450)                                       
                {
                    buff = 450;
                }

                dmuchawiec.wznos(buff);

                stopWatch.Reset();
            }
        }
        /// <summary>
        /// Metoda reagujaca na zdarzenie klikniecia przycisku "powrot"/"start" - start gry i znikniecie menu
        /// </summary>
        /// <param name="sender">Obiekt wysylajacy zdarzenie</param>
        /// <param name="e">Obiekt zawierajacy parametry zdarznia</param>
    
        private void powrot_Click(object sender, EventArgs e)
        {
            MainTimer.Start();
            start = true;
            startGry = true;
            this.menuPanel.Visible = false;
            this.powrot.Enabled = false;
            this.zapisWynikow.Enabled = false;
            this.zakoncz.Enabled = false;
        }
        /// <summary>
        /// Metoda reagujaca na zdarzenie klikniecia przycisku "Zapis Wynikow" - zapisanie wartosci licznikow do pliku (zrodlo-iternet
        /// StackOverflow)
        /// </summary>
        /// <param name="sender">Obiekt wysylajacy zdarzenie</param>
        /// <param name="e">Obiekt zawierajacy parametry zdarznia</param>
        private void zapisWynikow_Click(object sender, EventArgs e)
        {
           
            string dane = String.Format("Podsumowanie gry: "+System.Environment.NewLine+
                
                "Maksymalny Poziom: {0} " + System.Environment.NewLine +
                "Ilosc Punktow: {1} " + System.Environment.NewLine +

                "Calkowity czas dmuchania w milisekundach: {2}" + System.Environment.NewLine, 
               
                licznikPoziomu.ToString(), licznikOdleglosci.ToString(), 
               
                licznikDmuchania.ToString(), System.Environment.NewLine);

            System.IO.StreamWriter file = new System.IO.StreamWriter(".\\Podsumowanie.txt");
            file.WriteLine(dane);

            file.Close();

        }
       /// <summary>
       /// Metoda ragujaca na zdarznie nacisniecia przycisku "Zakoncz" - wyjscie z programu
       /// </summary>
        /// <param name="sender">Obiekt wysylajacy zdarzenie</param>
        /// <param name="e">Obiekt zawierajacy parametry zdarznia</param>
        private void zakoncz_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
       /// <summary>
       /// Metoda reagujaca na zdarzenie wcisniecia klawisza "Esc" - wywolanie meanu oraz powrot do gry
       /// </summary>
        /// <param name="sender">Obiekt wysylajacy zdarzenie</param>
        /// <param name="e">Obiekt zawierajacy parametry zdarznia</param>
        private void Esc_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                
                start = !start;
                if (start)
                {
                                                                       //pauza off
                    MainTimer.Start();
                    this.menuPanel.Visible = false;
                    this.powrot.Enabled = false;
                    this.zapisWynikow.Enabled = false;
                    this.zakoncz.Enabled = false;
                }
                else
                {
                    
                    MainTimer.Stop();                                   //pauza on
                    this.menuPanel.Visible = true;
                    this.powrot.Enabled = true;
                    this.powrot.Text = "Powrót";
                    this.zapisWynikow.Enabled = true;
                    this.zakoncz.Enabled = true;
                }
              }
        }
        /// <summary>
        /// Metodareagujaca na zdarzenie nacisniecia przycisku "Nowa Gra" - restart programu
        /// </summary>
        /// <param name="sender">Obiekt wysylajacy zdarzenie</param>
        /// <param name="e">Obiekt zawierajacy parametry zdarznia</param>
        private void nowaGra_Click(object sender, EventArgs e)
        {
            Application.Restart();
            this.nowaGra.Visible = false;
            this.nowaGra.Enabled = false;
        }
    }
}