/// B181200033 BAHADIR BÜNÜL

using Kacis.Library.Enum;
using Kacis.Library.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kacis.Library.Abstract
{
    internal abstract class Cisim : PictureBox, IHareketEden  //Hareket eden adamın hareket edebileceği alan ve ne kadar hareket edebileceğinin tanımlanması.
    {

        public Size HareketAlaniBoyutlari { get; }
        public int HareketMesafesi { get; protected set; }


        protected Cisim(Size hareketAlanBoyutlari)
        {
            HareketAlaniBoyutlari = hareketAlanBoyutlari;
            SizeMode = PictureBoxSizeMode.AutoSize;
        }





        public bool HareketEttir(Yon yon) //Adamın hareket edebileceği yönler
        {
            switch (yon)
            {
                case Yon.Saga:
                    return SagaHareketEttir();
                case Yon.Yukari:
                    return YukariHareketEttir();
                case Yon.Asagi:
                    return AsagiHareketEttir();
                default:
                    throw new ArgumentOutOfRangeException(nameof(yon), yon, null);
            }
        }

        private bool AsagiHareketEttir()
        {
            if (Top == 0) return true;

            var yeniTop = Top - HareketMesafesi;
            var tasacakMi = yeniTop < 0;
            Top = tasacakMi ? 0: yeniTop;

            return Top == 0;
            
        }

        private bool YukariHareketEttir()
        {
            if (Bottom == HareketAlaniBoyutlari.Height) return true;
            {
                var yeniBottom = Bottom + HareketMesafesi;
                var tasacakMi = yeniBottom > HareketAlaniBoyutlari.Height;

                var bot = tasacakMi ? HareketAlaniBoyutlari.Height : yeniBottom;
                Top = bot - Height;
                return Bottom == HareketAlaniBoyutlari.Height;
            }
        }

        private bool SagaHareketEttir()
        {
            if (Right == HareketAlaniBoyutlari.Width) return true;
            {
                var yeniRight = Right + HareketMesafesi;
                var tasacakMi = yeniRight > (HareketAlaniBoyutlari.Width);

                var right = tasacakMi ? HareketAlaniBoyutlari.Width : yeniRight;
                Left = right - Width;
                return Right == HareketAlaniBoyutlari.Width;
            }
        }
    }
}
