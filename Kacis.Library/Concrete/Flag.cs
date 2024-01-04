/// B181200033 BAHADIR BÜNÜL

using Kacis.Library.Abstract;
using System.Drawing;
using System.Windows.Forms;

namespace Kacis.Library.Concrete
{
    internal class Flag : HareketsizCisim //Panelin sağ tarafında bulunan bayrağın eklenmesi
    {
        public Flag(int height, int width)
        {
            Top = 50;
            Left = 550;
        }

    }
}