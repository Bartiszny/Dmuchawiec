/*<summary> Projekt z przedmiotu "Jezyki Programowania Wysokiego Poziomu"
*Gra "Dmuchawiec" na platforme "E-dmuchawka"
*</summary>
*<author>Bartlomiej Horiszny</author>
*<version>1.0</version>
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Gra
{

  /// <summary>
  /// Klasa przeszkody tworzaca i ustawiajaca przeszkody
  /// </summary>
    public class Sciana
    {
         
        /// <summary>
        /// Konstruktor klasy <c>Sciana</c> Pobieranie tekstury
        /// </summary>
        /// <param name="x">Skladowa pozioma punktu lokalizacji sciany</param>
        /// <param name="y">Skladowa pionowa punktu lokalizacji sciany</param>
        /// <param name="wysokosc">Ilosc obrazkow skladajacych sie na sciane</param>
        public Sciana(int x, int y, int wysokosc)
        {
            
            this.x = x;
            this.y = y;
            this.wysokosc = wysokosc;
           
            obraz = Image.FromFile(@".\Sources\cega.png", true);

        }  
                 
      
        /// <summary>
        /// Metoda przesuwajaca sciane
        /// </summary>
        
        public void suwaj()
        {
            x -= 10;
        }
        /// <summary>
        /// Metoda virtualna, tworzenie sciany 
        /// </summary>
        /// <param name="g">Obiekt klasy <c>Graphics</c> na ktorym odbywa sie rysowanie</param>
        
        public virtual void rysuj(Graphics g)
        {
           
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metoda pobierajaca pozycje obiektu
        /// </summary>
        /// <returns>Punkt o wspolrzednych x i y</returns>
        public Point pobierzPozycje()
        {
            return new Point(x, y);
        }
        /// <summary>
        /// Metoda sprawdzajaca, czy sciana znajduje sie juz poza ekranem
        /// </summary>
        /// <returns>Zmienna typu <c>bool</c></returns>
        public bool czyPozaEkranem()
        {
            if (x < -35)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
       /// <summary>
       /// Metoda virualna liczaca bezwgledna wysokosc przeszkody
       /// </summary>
       /// <returns>Wysokosc przeszkody</returns>
        public virtual int wysokoscWPikselach()
        {
            return wysokosc * obraz.Height;
        }
        /// <summary>
        /// Deklaracja pol lokalizacji i wysokosci
        /// </summary>
        protected int x, y, wysokosc;

       /// <summary>
       /// Deklaracja zmiennej obiektu klasy <c>Image</c>
       /// </summary>
        protected Image obraz;

       /// <summary>
       /// Hermetyzacja pola <c>wysokosc</c>
       /// </summary>
        public int Wysokosc
        {
            get { return wysokosc; }
            set { wysokosc = value; }
        }
        /// <summary>
        /// Hermetyzacja pola <c>y</c>
        /// </summary>
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        /// <summary>
        /// Hermetyzacja pola <c>x</c>
        /// </summary>
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        /// <summary>
        /// Hermetyzacja pola <c>Obraz</c>
        /// </summary>
        public Image Obraz
        {
            get { return obraz; }
            set { obraz = value; }
        }
    }

}
