/*<summary> Projekt z przedmiotu "Jezyki Programowania Wysokiego Poziomu"
*Gra "Dmuchawiec" na platforme "E-dmuchawka"
*</summary>
*<author>Bartlomiej Horiszny</author>
*<version>1.0</version>
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra
{
 /// <summary>
 /// Klasa pomocnicza likwidujaca miganie ekranu - zrodlo Internet(Stack OverFlow)
 /// </summary>
    public class DoubleBufferedPanel : Panel
    {   
        /// <summary>
        /// Konstruktor klasy pomocniczej
        /// </summary>
        public DoubleBufferedPanel()
        {
           
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();
        }
    }
}
