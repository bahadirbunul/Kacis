/// B181200033 BAHADIR BÜNÜL


using Kacis.Library.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kacis.Library.Interface
{
    internal interface IOyun //Oyunun interfacei
    {
        event EventHandler GecenSureDegisti;
        event EventHandler ArtanPuanDegisti;
        bool DevamEdiyorMu { get; }
        bool BasladiMi { get; }
        TimeSpan GecenSure { get; }
        int ArtanPuan { get; }

        void Baslat();
        void Duraklat();




        void HareketEt(Yon yon);

    }
}
