/// B181200033 BAHADIR BÜNÜL



using Kacis.Library.Concrete;
using Kacis.Library.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kacis.Desktop
{
    public partial class OyunEkraniFormu : Form
    {
        private readonly Oyun _oyun;
        
        public OyunEkraniFormu()
        {
            InitializeComponent();
            _oyun = new Oyun(oyunPanel);
            _oyun.GecenSureDegisti += Oyun_GecenSureDegisti;
            _oyun.ArtanPuanDegisti += Oyun_PuanDegisti;
            oyunDuraklat.Hide();
        }

        

        public string ad;

       

        private void OyunEkraniFormu_KeyDown(object sender, KeyEventArgs e) //Tuş kombinasyonları
        {
           
            
            switch (e.KeyCode)
            {
                case Keys.Space:
                    _oyun.Baslat();
                    
                    break;
                case Keys.F:
                    Application.Restart();

                    break;
                case Keys.P:
                    _oyun.Duraklat();
                    if (!oyunDuraklat.Visible)
                    {
                        
                        oyunDuraklat.Show();
                    }
                    else
                    {
                        
                        oyunDuraklat.Hide();
                    }



                    break;
                case Keys.Right:
                    _oyun.HareketEt(Yon.Saga);
                    
                    break;
                case Keys.Down:
                    _oyun.HareketEt(Yon.Yukari);
                    break;
                case Keys.Up:
                    _oyun.HareketEt(Yon.Asagi);
                    break;

            }

            
        }
        private void Oyun_GecenSureDegisti(object sender, EventArgs e) //Süre sayacının ekrana yazdırılması
        {
            sureLabel.Text = $"{_oyun.GecenSure.Seconds.ToString("D2")}";
        }

        private void Oyun_PuanDegisti(object sender, EventArgs e)
        {
            puan.Text = $"100";
        }

        private void OyunEkraniFormu_Load(object sender, EventArgs e) //Anaformdan çekilen oyuncu adının ekrana yazdırılması
        {
            oyuncuAdiOyunEkrani.Text =  ad;
        }

       
    }
}
