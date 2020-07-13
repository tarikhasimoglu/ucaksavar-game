using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucaksavar
{
    class Ucak:PictureBox
    {
        Random rnd;
        public Ucak()
        {
            rnd = new Random();
            Width = Properties.Resources.airplane.Width;
            Height = Properties.Resources.airplane.Height;
            Image = Properties.Resources.airplane;
        }

        public void BaslangicKonum(int infoPanelHieght,int oyunAlaniWidth)
        {
            Top = 0;
            Left = rnd.Next(0, oyunAlaniWidth-Width+1);
        }

        public void Ilerle()
        {
            Top += 10;
        }
    }
}
