/// B181200033 BAHADIR BÜNÜL

using Kacis.Library.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kacis.Library.Interface
{
    internal interface IHareketEden //Hareket edenleri belirttiğim interface
    {
        Size HareketAlaniBoyutlari {  get; }
        bool HareketEttir(Yon yon);
    }
}
