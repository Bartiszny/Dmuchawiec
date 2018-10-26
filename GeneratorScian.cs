using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra
{   
    /// <summary>
    /// Klasa do generacji scian (przeszkod)
    /// </summary>
    class GeneratorScian
    {
        /// <summary>
        /// Konstruktor klasy generujacej sciany
        /// </summary>
        /// <param name="wysokoscPanelu">Zmienna wysokosci panelu na ktorym dzieje sie rozgrywka</param>
        /// <param name="szerokoscPanelu">Zmienna szerokosci panelu na ktorym dzieje sie rozgrywka</param>
        public GeneratorScian(int wysokoscPanelu, int szerokoscPanelu)
        {
            
            this.wysokoscPanelu = wysokoscPanelu;
            this.szerokoscPanelu = szerokoscPanelu;
            maxLiczbaObrazkow = wysokoscPanelu / WYSOKOSC_OBRAZKA;
            generator = new Random(DateTime.Now.Millisecond);
        }

       /// <summary>
       /// Metoda tworzaca przeszkode(obiekt klasy <c>ScianaGorna</c>)
       /// </summary>
       /// <returns>Nowy obiekt przeszkody</returns>
        public  Sciana stworzScianeGorna()
        {
           
            int minWysokoscSciany = 5;
            int maxWysokoscSciany = 21;
            var wysokoscSciany = generator.Next(maxWysokoscSciany - minWysokoscSciany) + minWysokoscSciany;
            return new ScianaGorna(szerokoscPanelu - SZEROKOSC_OBRAZKA+1, 0, wysokoscSciany);
        }
       /// <summary>
       /// Metoda tworzaca przeszkode (obiekt klasy <c>ScianaDolna</c>), uzalezniona od wysokosci przeszkody gornej
       /// </summary>
       /// <param name="wysokoscScianyGornej">Zmienna wysokosci przeszkody gornej</param>
       /// <returns>Nowy obiekt przeszkody</returns>
        public  Sciana stworzScianeDolna(int wysokoscScianyGornej)
        {
            return new ScianaDolna(szerokoscPanelu - SZEROKOSC_OBRAZKA+1, wysokoscPanelu, maxLiczbaObrazkow - PRZERWA - wysokoscScianyGornej);
        }

       /// <summary>
       /// Pola stalych i generatora losowego
       /// </summary>
        private Random generator;
        public const int PRZERWA = 10;
        private const int WYSOKOSC_OBRAZKA = 21;
        private const int SZEROKOSC_OBRAZKA = 35;
        private int wysokoscPanelu;
        private int szerokoscPanelu;
        private int maxLiczbaObrazkow;
    }
}
