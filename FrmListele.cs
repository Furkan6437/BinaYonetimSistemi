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
    public partial class FrmListele : Form
    {
        public FrmListele()
        {
            InitializeComponent();
        }

        private void FrmListele_Load(object sender, EventArgs e)
        {

            dgvMulkler.ColumnCount = 6;
            dgvMulkler.Columns[0].Name = "Kapı No";
            dgvMulkler.Columns[1].Name = "Tip";
            dgvMulkler.Columns[2].Name = "Kat";
            dgvMulkler.Columns[3].Name = "Metrekare";
            dgvMulkler.Columns[4].Name = "Aidat";
            dgvMulkler.Columns[5].Name = "Kiracı Durumu";

            ListeyiDoldur();
        }
        private void ListeyiDoldur()
        {
            dgvMulkler.Rows.Clear();

            foreach (var mulk in VeriDeposu.Mulkler)
            {
                string tip = "";
                string kiraci = "Boş";

                if (mulk is Daire)
                {
                    tip = "Daire (Konut)";
                    if (((Daire)mulk).KiraciAdi != null)
                        kiraci = ((Daire)mulk).KiraciAdi;
                }
                else if (mulk is Dukkan)
                {
                    tip = "Dükkan (Ticari)";
                    if (((Dukkan)mulk).IsletmeAdi != "Yok")
                        kiraci = ((Dukkan)mulk).IsletmeAdi;
                }

                dgvMulkler.Rows.Add(
                    mulk.KapiNumarasi,
                    tip,
                    mulk.Kat,
                    mulk.Metrekare,
                    mulk.UcretHesapla() + " TL",
                    kiraci
                );

            }
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            dgvMulkler.Rows.Clear();

            string aranan = txtAra.Text.ToLower();

            string secilenFiltre = cmbFiltre.Text;

            foreach (var mulk in VeriDeposu.Mulkler)
            {
                string buMulkunTipi = (mulk is Daire) ? "Daire" : "Dükkan";


                bool isimdeVarMi = mulk.KapiNumarasi.ToLower().Contains(aranan);

                bool tipteVarMi = buMulkunTipi.ToLower().Contains(aranan);

                if (isimdeVarMi == true || tipteVarMi == true)
                {

                    string kiraci = "Boş";
                    if (mulk is Daire && ((Daire)mulk).KiraciAdi != null)
                        kiraci = ((Daire)mulk).KiraciAdi;
                    else if (mulk is Dukkan && ((Dukkan)mulk).IsletmeAdi != "Yok")
                        kiraci = ((Dukkan)mulk).IsletmeAdi;

                    dgvMulkler.Rows.Add(
                        mulk.KapiNumarasi,
                        buMulkunTipi,
                        mulk.Kat,
                        mulk.Metrekare,
                        mulk.UcretHesapla() + " TL",
                        kiraci
                    );
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvMulkler.SelectedRows.Count > 0)
            {
                int sira = dgvMulkler.SelectedRows[0].Index;

                var secilenMulk = VeriDeposu.Mulkler[sira];

                if (secilenMulk is IKiralanabilir)
                {
                    IKiralanabilir kiralikMulk = (IKiralanabilir)secilenMulk;

                    DialogResult cevap = MessageBox.Show("Bu mülke yeni kiracı girişi yapılsın mı?\n(Hayır derseniz mevcut kiracı çıkarılır)",
                                                         "Durum Güncelle",
                                                         MessageBoxButtons.YesNoCancel,
                                                         MessageBoxIcon.Question);

                    if (cevap == DialogResult.Yes)
                    {
                        kiralikMulk.Kirala("Yeni Kiracı");
                    }
                    else if (cevap == DialogResult.No)
                    {
                        kiralikMulk.KiraBitir();
                    }

                    ListeyiDoldur();
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlenecek bir kayıt seçin.");
            }
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvMulkler.SelectedRows.Count > 0)
            {
                string secilenKapiNo = dgvMulkler.SelectedRows[0].Cells[0].Value.ToString();

                DialogResult cevap = MessageBox.Show(secilenKapiNo + " kapı numaralı mülkü silmek istiyor musunuz?",
                                                     "Silme Onayı",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

                if (cevap == DialogResult.Yes)
                {

                    for (int i = 0; i < VeriDeposu.Mulkler.Count; i++)
                    {
                        if (VeriDeposu.Mulkler[i].KapiNumarasi == secilenKapiNo)
                        {
                            VeriDeposu.Mulkler.RemoveAt(i);
                            break;
                        }
                    }


                    btnFiltrele_Click(sender, e);

                    MessageBox.Show("Kayıt başarıyla silindi.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir satır seçin!");
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            {
                dgvMulkler.Rows.Clear();

                string secilenFiltre = cmbFiltre.Text.Trim();
                string arananKelime = txtAra.Text.ToLower();

                foreach (var mulk in VeriDeposu.Mulkler)
                {

                    if (secilenFiltre == "Daireler" && !(mulk is Daire))
                    {
                        continue;
                    }

                    if (secilenFiltre == "Dükkanlar" && !(mulk is Dukkan))
                    {
                        continue;
                    }

                    if (!string.IsNullOrEmpty(arananKelime) && !mulk.KapiNumarasi.ToLower().Contains(arananKelime))
                    {
                        continue;
                    }

                    string tip = "";
                    string kiraci = "Boş";

                    if (mulk is Daire)
                    {
                        tip = "Daire";
                        kiraci = ((Daire)mulk).KiraciAdi ?? "Yok";
                    }
                    else
                    {
                        tip = "Dükkan";
                        kiraci = ((Dukkan)mulk).IsletmeAdi;
                    }

                    dgvMulkler.Rows.Add(
                        mulk.KapiNumarasi,
                        tip,
                        mulk.Kat,
                        mulk.Metrekare,
                        mulk.UcretHesapla() + " TL",
                        kiraci
                    );
                }
            }
        }

        private void btnFiltrele_Click_1(object sender, EventArgs e)
        {
            dgvMulkler.Rows.Clear();

            string aranan = txtAra.Text.ToLower();

            foreach (var mulk in VeriDeposu.Mulkler)
            {
                string buMulkunTipi = (mulk is Daire) ? "daire" : "dükkan";


                bool kapidaVarMi = mulk.KapiNumarasi.ToLower().Contains(aranan);

                bool tipteVarMi = buMulkunTipi.Contains(aranan);

                if (kapidaVarMi == true || tipteVarMi == true)
                {
                    string kiraci = "Boş";

                    if (mulk is Daire && ((Daire)mulk).KiraciAdi != null)
                        kiraci = ((Daire)mulk).KiraciAdi;
                    else if (mulk is Dukkan && ((Dukkan)mulk).IsletmeAdi != "Yok")
                        kiraci = ((Dukkan)mulk).IsletmeAdi;

                    string ekrandakiTip = (mulk is Daire) ? "Daire" : "Dükkan";

                    dgvMulkler.Rows.Add(
                        mulk.KapiNumarasi,
                        ekrandakiTip,
                        mulk.Kat,
                        mulk.Metrekare,
                        mulk.UcretHesapla() + " TL",
                        kiraci
                    );
                }
            }
        }
    }
}
