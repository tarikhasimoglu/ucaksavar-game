using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucaksavar
{
    class Mermi:PictureBox
    {

        public Mermi()
        {
            Height = Properties.Resources.bullet.Height;
            Width = Properties.Resources.bullet.Width;
            Image = Properties.Resources.bullet;
        }

        public void BaslangicKonum(int ucaksavarWidthBolu2ArtLeft,
            int panelHeghtEksiUcaksavarHeight)
        {
            Left = ucaksavarWidthBolu2ArtLeft;
            Top = panelHeghtEksiUcaksavarHeight;
        }

        public void Hareket()
        {
            Top -= 10; 
        }

    }
}
