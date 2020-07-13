using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucaksavar
{
    class Oyun
    {
        Control oyunAlani;
        Control infoPanel;
        Control infoLabel;
        //score 
        Control score;
        int simdikiScore;
        //Ucaksavar Degeskenleri
        Ucaksavar ucaksavar;
        //Mermi Degiskenleri
        Mermi[] mermi;
        Timer mermiTimer;
        int mermiSayisi;
        //Ucak
        Ucak[] ucak;
        Timer ucakOlusturTimer;
        Timer ucakIlerleTimer;
        int ucakSayisi;
        //Oyun Durumu
        bool oyunDurumu = false;
        bool oyunBitiMi = false;
        Timer isabetMi;
        public Oyun(Control oyunAlani, Control infoPanel, Control infoLabel, Control score)
        {
            this.oyunAlani = oyunAlani;
            this.infoPanel = infoPanel;
            this.infoLabel = infoLabel;
            this.score = score;
            //Ucaksavar
            UcaksavarOlustur();
            //Mermi
            mermi = new Mermi[25000];
            mermiTimer = new Timer();
            mermiTimer.Interval = 50;
            mermiTimer.Tick += MermiTimer_Tick;
            //Ucak
            ucak = new Ucak[25000];
            //ucak olustur
            ucakOlusturTimer = new Timer();
            ucakOlusturTimer.Interval = 3000;
            ucakOlusturTimer.Tick += UcakTimer_Tick;
            //ucak ilerle
            ucakIlerleTimer = new Timer();
            ucakIlerleTimer.Interval = 150;
            ucakIlerleTimer.Tick += UcakIlerleTimer_Tick;
            //isabetMi
            isabetMi = new Timer();
            isabetMi.Interval = 50;
            isabetMi.Tick += İsabetMi_Tick;
            //funcitons
            oyunAlani.Resize += OyunAlani_Resize;
        }

        private void UcaksavarOlustur()
        {
            ucaksavar = new Ucaksavar();
            oyunAlani.Controls.Add(ucaksavar);
            ucaksavar.OyunAlaniEbatAt(oyunAlani.Width, oyunAlani.Height);
        }


        private void İsabetMi_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < ucakSayisi; i++)
            {
                if (ucak[i] != null)
                {
                    if (ucak[i].Top + ucak[i].Height > oyunAlani.Height - ucaksavar.Height)
                    {
                        OyunBitir();
                    }
                }
            }
            //her mermi her ucakla kontrol ediyor
            for (int i = 0; i < mermiSayisi; i++)
            {
                for (int j = 0; j < ucakSayisi; j++)
                {
                    //isabet edildiginde mermi ve ucak yok edilir
                    if (mermi[i] != null && ucak[j] != null)
                    {
                        //Top tarafi isabet etti
                        if (mermi[i].Top < ucak[j].Top + Properties.Resources.airplane.Height)
                        {
                            //Left ve Right tarafi isabet etti
                            if (mermi[i].Left >= ucak[j].Left - 20 &&
                                mermi[i].Right <= ucak[j].Right + 20)
                            {
                                //score arttir
                                simdikiScore++;
                                score.Text = Convert.ToString(simdikiScore);
                                //gizle
                                mermi[i].Visible = false;
                                ucak[j].Visible = false;
                                //yoket
                                mermi[i] = null;
                                ucak[j] = null;
                            }
                        }
                    }
                }

            }
        }

        private void OyunBitir()
        {
            OyunuBaslatDurdur();
            oyunBitiMi = true;
        }


        private void Sifirla()
        {
            mermi = null;
            ucak = null;
            mermiSayisi = 0;
            ucakSayisi = 0;
            mermi = new Mermi[25000];
            ucak = new Ucak[25000];
            oyunAlani.Controls.Clear();
            UcaksavarOlustur();
            oyunBitiMi = false;
            simdikiScore = 0;
            score.Text = Convert.ToString(simdikiScore);

        }

        private void UcakIlerleTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < ucakSayisi; i++)
            {
                if (ucak[i] != null)
                {
                    ucak[i].Ilerle();
                }
            }
        }
        //baslatmak icin zamanlayicileri calistiririz
        public void OyunuBaslatDurdur()
        {
            if (oyunBitiMi)
            {
                Sifirla();
            }
            if (!oyunDurumu)
            {
                infoLabel.Text = "Oyunu DURDURMAK için ENTER tuşuna basın.\nUçaksavarı hareket ettirmek için SAĞ / SOL YÖN TUŞLARINI kullanın.\nAteş etmek için BOŞLUK tuşuna basın.";
                ucakOlusturTimer.Start();
                ucakIlerleTimer.Start();
                mermiTimer.Start();
                isabetMi.Start();
                oyunDurumu = true;
            }
            else
            {
                infoLabel.Text = "Oyunu BAŞLATMAK için ENTER tuşuna basın.\nUçaksavarı hareket ettirmek için SAĞ / SOL YÖN TUŞLARINI kullanın.\nAteş etmek için BOŞLUK tuşuna basın.";
                ucakOlusturTimer.Stop();
                ucakIlerleTimer.Stop();
                mermiTimer.Stop();
                isabetMi.Stop();
                oyunDurumu = false;
            }
        }

        private void UcakTimer_Tick(object sender, EventArgs e)
        {
            UcakOlustur();
            ucakOlusturTimer.Interval = 2500 - (simdikiScore * 100);

        }

        private void UcakOlustur()
        {
            ucak[ucakSayisi] = new Ucak();
            ucak[ucakSayisi].BaslangicKonum(infoPanel.Height, oyunAlani.Width);
            oyunAlani.Controls.Add(ucak[ucakSayisi]);
            ucakSayisi++;
        }

        private void MermiTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < mermiSayisi; i++)
            {
                if (mermi[i] != null)
                {
                    mermi[i].Hareket();

                    //mermi oyun alanının en ustüne ulastığında ekrandan kaybolacaktır
                    if (mermi[i].Top + mermi[i].Height + 20 < infoPanel.Height)
                    {
                        mermi[i].Visible = false;
                        mermi[i] = null;
                    }
                }
            }
        }

        private void OyunAlani_Resize(object sender, EventArgs e)
        {
            ucaksavar.OyunAlaniEbatAt(oyunAlani.Width, oyunAlani.Height);
        }

        public void UcaksavarSaga()
        {
            if (oyunDurumu)
                ucaksavar.SagaGit();
        }

        public void UcaksavarSola()
        {
            if (oyunDurumu)
                ucaksavar.SolaGit();
        }

        private void MermiBaslangicKonumAta()
        {

            //tam ucaksavarin ortasinda gelmesi icin biraz uzun oldu parametre 
            mermi[mermiSayisi].BaslangicKonum((ucaksavar.Width / 2) +
                (ucaksavar.Left) - (Properties.Resources.bullet.Width / 2),
                (oyunAlani.Height) - (ucaksavar.Height) - 30);
        }

        public void MermiOlustur()
        {
            if (oyunDurumu)
            {
                mermi[mermiSayisi] = new Mermi();
                MermiBaslangicKonumAta();
                //Oyun sahnesine ekle
                oyunAlani.Controls.Add(mermi[mermiSayisi]);
                mermiSayisi++;
            }
        }

    }
}
