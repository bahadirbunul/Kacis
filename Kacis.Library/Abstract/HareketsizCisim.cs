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
    internal abstract class HareketsizCisim : PictureBox //Kutu ve Tuzak gibi hareket etmeyen cisimler için kullandığım abstract sınıf
    {

      
        protected HareketsizCisim()
        {
            SizeMode = PictureBoxSizeMode.AutoSize;
        }





      
    }
}
