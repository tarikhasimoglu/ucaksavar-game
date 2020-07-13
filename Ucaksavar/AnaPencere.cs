using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucaksavar
{
    public partial class AnaPencere : Form
    {
        Oyun oyun;
        public AnaPencere()
        {
            InitializeComponent();
            Icon = Properties.Resources.ammo;
            oyun = new Oyun(oyunAlani,infoPanel,infoLabel,score);
            DoubleBuffered = true;
            Text = "UÇAKSAVAR";
            //functions
            KeyDown += AnaPencere_KeyDown;
        }

        private void AnaPencere_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                oyun.UcaksavarSola();
            }
            if (e.KeyCode == Keys.Right)
            {
                oyun.UcaksavarSaga();
            }
            if (e.KeyCode == Keys.Space)
            {
                oyun.MermiOlustur();
            }
            if (e.KeyCode == Keys.Enter)
            {
                oyun.OyunuBaslatDurdur();
            }
        }
    }
}
