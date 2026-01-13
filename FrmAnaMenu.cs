using BinaYonetimSistemi.Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaYonetimSistemi
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void btnMulkEkle_Click(object sender, EventArgs e)
        {
            FrmMulkEkle ekleFormu = new FrmMulkEkle();
            ekleFormu.ShowDialog(); 
        }

        private void btnListele_Click(object sender, EventArgs e)
        {

            int daireSayisi = 0;
            int dukkanSayisi = 0;
            double toplamGelir = 0;

            foreach (var siradakiMulk in VeriDeposu.Mulkler)
            {
                if (siradakiMulk is Daire)
                {
                    daireSayisi++; 
                }
                else if (siradakiMulk is Dukkan)
                {
                    dukkanSayisi++; 
                }

                toplamGelir += siradakiMulk.UcretHesapla();
            }

            lblToplamSayi.Text = "Toplam Mülk: " + VeriDeposu.Mulkler.Count.ToString();
            lblDaireSayisi.Text = "Daire Sayısı: " + daireSayisi.ToString();
            lblDukkanSayisi.Text = "Dükkan Sayısı: " + dukkanSayisi.ToString();

            lblToplamGelir.Text = "Tahmini Gelir: " + toplamGelir.ToString() + " TL";

            MessageBox.Show("Raporlar güncellendi ve ekrana yansıtıldı!", "Rapor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Programdan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {

                FrmListele listeFormu = new FrmListele();
                listeFormu.ShowDialog();
            
        }

       
    }
}
