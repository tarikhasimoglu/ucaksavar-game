using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucaksavar
{
    class Ucaksavar:PictureBox
    {
        int oyunAlaniWidth;
        int oyunAlaniHeight;

       public Ucaksavar()
        {
            Height = Properties.Resources.tank.Height;
            Width = Properties.Resources.tank.Width;
            Image = Properties.Resources.tank;

        }

        // atiyor ve guncelliyor
        public void OyunAlaniEbatAt(int oyunAlaniWidth,int oyunAlaniHeight)
        {
            this.oyunAlaniWidth = oyunAlaniWidth;
            this.oyunAlaniHeight = oyunAlaniHeight;
            KonumAyarla();
        }

        private void KonumAyarla()
        {
            Left = (oyunAlaniWidth - Width) / 2;
            Top = oyunAlaniHeight - Height;
        }

        public void SagaGit()
        {
            if (Left+Width<oyunAlaniWidth)
            {
                Left += 20;
            }
        }

        public void SolaGit()
        {
            if (Left>0)
            {
                Left -= 20;
            }
        }

    }
}
