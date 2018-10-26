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

namespace Gra
{

    /// <summary>
    /// Klasa dziedziczaca po klasie <c>Sciana</c> i odpowiadająca za dolna przeszkode
    /// </summary>
    class ScianaDolna : Sciana
    {
        /// <summary>
        /// Konstruktor klasy. Paramtery odwoluja sie do klasy nadrzednej
        /// </summary>
        /// <param name="x">Skladowa pozioma punktu lokalizacji</param>
        /// <param name="y">Skladowa pionowa punktu lokalizacji</param>
        /// <param name="wysokoscSciany">Liczba obrazkow skladajacych sie na obiekt</param>
        public ScianaDolna(int x, int y, int wysokoscSciany) : base(x, y, wysokoscSciany)
        {
            
        }

        /// <summary>
        /// Metoda przeslaniajaca virtualna metode w klasie nadrzednej, tworzenie sciany 
        /// </summary>
        /// <param name="g">Obiekt klasy <c>Graphics</c> na ktorym odbywa sie rysowanie</param>
        public override void rysuj(System.Drawing.Graphics g)
        {
            for (int i = 0; i < Wysokosc; i++)
            {
                g.DrawImage(Obraz, X, Y - (1 + i) * Obraz.Height);
            }
        }

        /// <summary>
        /// Metoda przelaniajaca virualna metode klasy nadrzednej
        /// </summary>
        /// <returns>Bezwgledna wysokosc sciany</returns>
        public override int wysokoscWPikselach()
        {
            return Y - (wysokosc * obraz.Height);
        }
    }
}
