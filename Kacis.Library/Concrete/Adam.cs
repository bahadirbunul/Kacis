/// B181200033 BAHADIR BÜNÜL


using Kacis.Library.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kacis.Library.Concrete
{
    internal class Adam : Cisim
    {
        
        
        public Adam(int panelBoyutlari, int panelWidth, Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari) //Adamın paneldeki konumu ve hareket etmesini istediğim mesafe ayarı
        {
            
            Top = (panelBoyutlari-Height)/2;
            HareketMesafesi = Width/2;
        }

        public bool YandiMi(List<Tuzak> tuzaklar) //Adam tuzaklardan herhangi birisine denk geldi mi?
        {


            var yandiMi = tuzaklar[0].Top == Top && tuzaklar[0].Left == Left || tuzaklar[1].Top == Top && tuzaklar[1].Left == Left || tuzaklar[2].Top == Top && tuzaklar[2].Left == Left || tuzaklar[3].Top == Top && tuzaklar[3].Left == Left || tuzaklar[4].Top == Top && tuzaklar[4].Left == Left || tuzaklar[5].Top == Top && tuzaklar[5].Left == Left || tuzaklar[6].Top == Top && tuzaklar[6].Left == Left || tuzaklar[7].Top == Top && tuzaklar[7].Left == Left || tuzaklar[8].Top == Top && tuzaklar[8].Left == Left || tuzaklar[9].Top == Top && tuzaklar[9].Left == Left;
            if (yandiMi)
            {
                return true;
            }
            return false;







            
        }


    }
}
