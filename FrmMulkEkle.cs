using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinaYonetimSistemi.Siniflar;

namespace BinaYonetimSistemi
{
    public partial class FrmMulkEkle : Form
    {
        public FrmMulkEkle()
        {
            InitializeComponent();
        }

       

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string kapi = txtKapiNo.Text;

                int m2 = int.Parse(txtMetrekare.Text);
                int kat = int.Parse(txtKat.Text);

                if (rbDaire.Checked)
                {
                    string oda = cmbOdaSayisi.Text;
                    Daire yeniDaire = new Daire(kapi, m2, kat, oda);

                    VeriDeposu.Mulkler.Add(yeniDaire);
                }
                else
                {
                    Dukkan yeniDukkan = new Dukkan(kapi, m2, kat);

                    VeriDeposu.Mulkler.Add(yeniDukkan);
                }

                MessageBox.Show("Mülk başarıyla sisteme eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen metrekare ve kat alanlarına sadece SAYI giriniz!", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            txtKapiNo.Clear();
            txtMetrekare.Clear();
            txtKat.Clear();
            rbDaire.Checked = true;
            txtKapiNo.Focus(); 
        }

        private void rbDaire_CheckedChanged(object sender, EventArgs e)
        {
            pnlOdaAlani.Visible = true;
        }

        private void rbDukkan_CheckedChanged(object sender, EventArgs e)
        {
            pnlOdaAlani.Visible = false;
        }

       
    }
}
