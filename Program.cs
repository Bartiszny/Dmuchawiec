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
/*<summary> Projekt z przedmiotu "Jezyki Programowania Wysokiego Poziomu"
*Gra "Dmuchawiec" na platforme "E-dmuchawka"
*</summary>
*<author>Bartlomiej Horiszny</author>
*<version>1.0</version>
*/
 namespace Gra
{
  
/// <summary>
/// GLOWNA KLASA MAIN
/// </summary>
    internal sealed class Program
    {  
       [STAThread]
               
        static void Main(string[] args)
        {
          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Okno());
                   }
    }
}
