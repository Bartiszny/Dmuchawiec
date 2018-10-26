/*<summary> 
 * Projekt z przedmiotu "Jezyki Programowania Wysokiego Poziomu"
*Gra "Dmuchawiec" na platforme "E-dmuchawka"
*
*<author>Bartlomiej Horiszny</author>
*<version>1.0</version>
 *</summary>
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
 /// Klasa obiektu sterowanego - platka dmuchawca
 /// </summary>
    public class Dmuchawiec
    {
     /// <summary>
     /// Konstruktor klasy <c>Dmuchawiec</c>, ustawienia poczatkowe i tekstura
     /// </summary>
        public Dmuchawiec()
    {
        x = 65;
        y = 350;
        
        obraz = Image.FromFile(@".\Sources\dmch1.3.png", true);
       
    }
    /// <summary>
    /// Metoda odpowiedzialna za podnoszenie obiektu
    /// </summary>
    /// <param name="buff">Zmienna bufora wielkosci skoku obiektu</param>
        public void wznos(double buff)
        {
            y = (int)buff;
        }
/// <summary>
/// Metoda odpowiedzialna za opadanie obiektu
/// </summary>
        public void opadaj()
        {
            y += 7;
        }
        /// <summary>
        /// Metoda wykrywjaca kolizje obiektu sterowanego z gorna krawedzia planszy
        /// </summary>
        /// <returns>Wartosc pola klasy <c>bool</c></returns>
        public bool sprawdzKolizaSufit()
        {
            if (y <= 7)
               
                return false;
           
            else return true;
        }
        /// <summary>
        /// Metoda wykrywjaca kolizje obiektu sterowanego z dolna krawedzia planszy
        /// </summary>
        /// <returns>Wartosc pola klasy <c>bool</c></returns>
        public bool sprawdzKolizjaPodloga()
        {
            if (y >= 560)
                return false;
            else return true;
         }
        /// <summary>
        /// Metoda wykrywjaca kolizje obiektu sterowanego z przeszkoda
        /// </summary>
       /// <param name="sciana">Obiekt klasy <c>Sciana</c></param>
        /// <returns>Wartosc pola klasy <c>bool</c></returns>
        public bool sprawdzKolizjaSciana(Sciana sciana)
        {


            if (sciana.GetType() == typeof(ScianaGorna))
            {
                if ((x + 65) == sciana.X && y <= sciana.wysokoscWPikselach())
                {
                    return false;
                }
                
                else return true;
            }
            else
               
                if (sciana.GetType() == typeof(ScianaDolna))
                {
                    if ((x + 65) == sciana.X && y+obraz.Height >= sciana.wysokoscWPikselach())
                    {
                       
                        return false;
                    }
                    else return true;
                }
                else return true;
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
        /// Deklaracja pol pozycji i wymiarow
        /// </summary>
        private int x, y;

        /// <summary>
        /// Deklaracja pola klasy <c>Image</c>
        /// </summary>
        private Image obraz;

        /// <summary>
        /// Hermetyzacja pola y
        /// </summary>
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        /// <summary>
        /// Hermetyzacja pola x
        /// </summary>
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        /// <summary>
        /// Hermetyzacja pola klasy <c>Image</c>
        /// </summary>
        public Image Obraz
        {
            get { return obraz; }
            set { obraz = value; }
        }
    }
}
