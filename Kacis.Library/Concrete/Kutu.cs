/// B181200033 BAHADIR BÜNÜL

using Kacis.Library.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kacis.Library.Concrete
{
    internal class Kutu : HareketsizCisim // Taş karoların yerlerinin belirlenerek eklenmesi
    {
        public Kutu(int panelYuksekligi, int panelGenisligi, int kutuNo)
        {
            switch (kutuNo)
            {
                case 1:
                    Top = 0;
                    Left = 50;
                    break;
                case 2:
                    Top = 50;
                    Left = 50;
                    break;
                case 3:
                    Top = 100;
                    Left = 50;
                    break;
                case 4:
                    Top = 0;
                    Left = 100;
                    break;
                case 5:
                    Top = 50;
                    Left = 100;
                    break;
                case 6:
                    Top = 100;
                    Left = 100;
                    break;
                case 7:
                    Top = 0;
                    Left = 150;
                    break;
                case 8:
                    Top = 50;
                    Left = 150;
                    break;
                case 9:
                    Top = 100;
                    Left = 150;
                    break;
                case 10:
                    Top = 0;
                    Left = 200;
                    break;
                case 11:
                    Top = 50;
                    Left = 200;
                    break;
                case 12:
                    Top = 100;
                    Left = 200;
                    break;
                case 13:
                    Top = 0;
                    Left = 250;
                    break;
                case 14:
                    Top = 50;
                    Left = 250;
                    break;
                case 15:
                    Top = 100;
                    Left = 250;
                    break;
                case 16:
                    Top = 0;
                    Left = 300;
                    break;
                case 17:
                    Top = 50;
                    Left = 300;
                    break;
                case 18:
                    Top = 100;
                    Left = 300;
                    break;
                case 19:
                    Top = 0;
                    Left = 350;
                    break;
                case 20:
                    Top = 50;
                    Left = 350;
                    break;
                case 21:
                    Top = 100;
                    Left = 350;
                    break;
                case 22:
                    Top = 0;
                    Left = 400;
                    break;
                case 23:
                    Top = 50;
                    Left = 400;
                    break;
                case 24:
                    Top = 100;
                    Left = 400;
                    break;
                case 25:
                    Top = 0;
                    Left = 450;
                    break;
                case 26:
                    Top = 50;
                    Left = 450;
                    break;
                case 27:
                    Top = 100;
                    Left = 450;
                    break;
                case 28:
                    Top = 0;
                    Left = 500;
                    break;
                case 29:
                    Top = 50;
                    Left = 500;
                    break;
                case 30:
                    Top = 100;
                    Left = 500;
                    break;

            }


        }

    }
}
