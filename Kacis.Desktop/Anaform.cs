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
    public partial class Anaform : Form
    {
        
        public Anaform()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

       

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (oyuncuAdiTextBox.Text=="")
            {
                MessageBox.Show("Oyuncu adınızı giriniz.");  // Oyuncu adını kullanıcıdan aldığımız kısım.
            }
            else
            {
                OyunEkraniFormu oyunForm = new OyunEkraniFormu();
                oyunForm.ad = oyuncuAdiTextBox.Text;
                oyunForm.Show();
                this.Hide();
            }
            
        }

      

        

        private void bestscor_Click(object sender, EventArgs e)
        {

        }

        private void tusinfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yön tuşları ile adamı hareket ettirebilirsiniz."); //Tuş takım bilgisi
        }
    }
}
