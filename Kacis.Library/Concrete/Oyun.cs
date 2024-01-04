/// B181200033 BAHADIR BÜNÜL

using Kacis.Library.Enum;
using Kacis.Library.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kacis.Library.Concrete
{
    public class Oyun : IOyun
    {
        private readonly Timer _gecenSureTimer = new Timer { Interval = 1000}; //Süre sayaç ayarı
        private readonly Timer _oyunTimer = new Timer { Interval = 10};
        private int _artanPuan;
        
        private TimeSpan _gecenSure;
        private readonly Panel _oyunPanel;
        private Adam _adam;
        private readonly List<Tuzak> _tuzaklar = new List<Tuzak>(); //Tuzakların listesi


        public event EventHandler GecenSureDegisti;
        public event EventHandler ArtanPuanDegisti;

        public bool DevamEdiyorMu { get; private set; }
        public bool BasladiMi { get; private set; }


        private bool kaybettiMi;

        public int ArtanPuan
        {
            get => _artanPuan;
            private set
            {
                _artanPuan = value;
                ArtanPuanDegisti?.Invoke(this, EventArgs.Empty);

            }
        }

        public TimeSpan GecenSure
        {
            get => _gecenSure;
            private set
            {
                _gecenSure = value;
                GecenSureDegisti?.Invoke(this, EventArgs.Empty);
            }
        }

        public Oyun(Panel oyunPanel)
        {
            _oyunPanel = oyunPanel;
            _gecenSureTimer.Tick += GecenSureTimer_Tick;
            _oyunTimer.Tick += OyunTimer_Tick;
        }

        

        private void GecenSureTimer_Tick(object sender, EventArgs e)
        {
            GecenSure += TimeSpan.FromSeconds(1);
            
        }

        private void OyunTimer_Tick(object sender, EventArgs e)
        {
            Kaybetti();

        }


        

        public void Baslat()
        {
            //Random bir şekilde oluşturulan tuzaklar
            Random random = new Random();
            int randomSayi1 = random.Next(1, 4);
            int randomSayi2 = random.Next(4, 7);
            int randomSayi3 = random.Next(7, 10);
            int randomSayi4 = random.Next(10, 13);
            int randomSayi5 = random.Next(13, 16);
            int randomSayi6 = random.Next(16, 19);
            int randomSayi7 = random.Next(19, 22);
            int randomSayi8 = random.Next(22, 25);
            int randomSayi9 = random.Next(25, 28);
            int randomSayi10 = random.Next(28, 31);

            int tuzakSayi1 = random.Next(1, 4);
            int tuzakSayi2 = random.Next(1, 4);
            int tuzakSayi3 = random.Next(1, 4);
            int tuzakSayi4 = random.Next(1, 4);
            int tuzakSayi5 = random.Next(1, 4);
            int tuzakSayi6 = random.Next(1, 4);
            int tuzakSayi7 = random.Next(1, 4);
            int tuzakSayi8 = random.Next(1, 4);
            int tuzakSayi9 = random.Next(1, 4);
            int tuzakSayi10 = random.Next(1, 4);

            if (BasladiMi) return;
            BasladiMi = true;
            _gecenSureTimer.Start();
            _oyunTimer.Start();

            AdamOlustur();
            TuzakOlustur(randomSayi1, tuzakSayi1);
            TuzakOlustur(randomSayi2, tuzakSayi2);
            TuzakOlustur(randomSayi3, tuzakSayi3);
            TuzakOlustur(randomSayi4, tuzakSayi4);
            TuzakOlustur(randomSayi5, tuzakSayi5);
            TuzakOlustur(randomSayi6, tuzakSayi6);
            TuzakOlustur(randomSayi7, tuzakSayi7);
            TuzakOlustur(randomSayi8, tuzakSayi8);
            TuzakOlustur(randomSayi9, tuzakSayi9);
            TuzakOlustur(randomSayi10, tuzakSayi10);
            KutuOlustur(1);
            KutuOlustur(2);
            KutuOlustur(3);
            KutuOlustur(4);
            KutuOlustur(5);
            KutuOlustur(6);
            KutuOlustur(7);
            KutuOlustur(8);
            KutuOlustur(9);
            KutuOlustur(10);
            KutuOlustur(11);
            KutuOlustur(12);
            KutuOlustur(13);
            KutuOlustur(14);
            KutuOlustur(15);
            KutuOlustur(16);
            KutuOlustur(17);
            KutuOlustur(18);
            KutuOlustur(19);
            KutuOlustur(20);
            KutuOlustur(21);
            KutuOlustur(22);
            KutuOlustur(23);
            KutuOlustur(24);
            KutuOlustur(25);
            KutuOlustur(26);
            KutuOlustur(27);
            KutuOlustur(28);
            KutuOlustur(29);
            KutuOlustur(30);
            

            Flag();



        } //Oyun başlatıldığında çalışacak metod

        private void AdamOlustur() //Adamı ekleme.

        {

            _adam = new Adam(_oyunPanel.Height, _oyunPanel.Width, _oyunPanel.Size)
            {

                Image = Image.FromFile(@"Image\adam.png")
            };
            _oyunPanel.Controls.Add(_adam);


        } 

        private void KutuOlustur(int kutuNo) //Kutuları ekleme
            
        {
            var kutu = new Kutu(_oyunPanel.Height, _oyunPanel.Width, kutuNo)
            {
                 Image = Image.FromFile(@"Image\kutu.png")
            };
            _oyunPanel.Controls.Add(kutu);
        }

        
        private void TuzakOlustur(int tuzakNo, int tuzakSayi) //Tuzakları ekleme ve gizleme

        {

            var tuzak = new Tuzak(_oyunPanel.Height, _oyunPanel.Width, tuzakNo, tuzakSayi)
            {
            Image = Image.FromFile($"Image\\tuzak{tuzakSayi}.png")
            };

            tuzak.Hide();
            _tuzaklar.Add(tuzak);
            _oyunPanel.Controls.Add(tuzak);
           
        }

        private void Flag()

        {
            var flag = new Flag(_oyunPanel.Height, _oyunPanel.Width)
            {
                Image = Image.FromFile(@"Image\raceflag.png")
            };
            _oyunPanel.Controls.Add(flag);
        } //Bayrağı ekleme

        public void Kaybetti()
        {


            kaybettiMi = _adam.YandiMi(_tuzaklar); //Adam tuzağa denk geldiyse true dönecek.

            
            if (kaybettiMi) // oyun sonlanacak.
            {
                for (int i = 0; i < 10; i++)
                {
                    _tuzaklar[i].Show();
                }
                _gecenSureTimer.Stop();
                _oyunTimer.Stop();
                _oyunPanel.Controls.Remove(_adam);

            }





        }


        public void Duraklat()
        {
            if (!DevamEdiyorMu) // Devam etmiyorsa süreyi durduracak.
            {
                
                DevamEdiyorMu = true;
                _gecenSureTimer.Stop();
            }
            else {
                DevamEdiyorMu = false;
                _gecenSureTimer.Start();
            }
            
        }

       


       

        public void HareketEt(Yon yon) //Adamın hem hareket etmesini hem de en sağa ulaştığında oyunu kazanmasını sağlama.
        {
            if (!DevamEdiyorMu)
            {
                
                if (yon == Yon.Saga)
                {
                    bool kazandi = _adam.HareketEttir(Yon.Saga);
                    if (kazandi)
                    {
                        _gecenSureTimer.Stop();
                        

                    }
                }
                else
                {
                    _adam.HareketEttir(yon);

                }

                


            }


        }

       
    }
}
