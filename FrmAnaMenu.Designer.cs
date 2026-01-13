
namespace BinaYonetimSistemi
{
    partial class FrmAnaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnMulkEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblToplamGelir = new System.Windows.Forms.Label();
            this.lblDukkanSayisi = new System.Windows.Forms.Label();
            this.lblDaireSayisi = new System.Windows.Forms.Label();
            this.lblToplamSayi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnRapor);
            this.panel1.Controls.Add(this.btnListele);
            this.panel1.Controls.Add(this.btnMulkEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 536);
            this.panel1.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCikis.Location = new System.Drawing.Point(0, 138);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(435, 46);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRapor.Location = new System.Drawing.Point(0, 92);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(435, 46);
            this.btnRapor.TabIndex = 2;
            this.btnRapor.Text = "Raporlar";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnListele
            // 
            this.btnListele.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListele.Location = new System.Drawing.Point(0, 46);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(435, 46);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Mülk Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnMulkEkle
            // 
            this.btnMulkEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMulkEkle.Location = new System.Drawing.Point(0, 0);
            this.btnMulkEkle.Name = "btnMulkEkle";
            this.btnMulkEkle.Size = new System.Drawing.Size(435, 46);
            this.btnMulkEkle.TabIndex = 0;
            this.btnMulkEkle.Text = "Mülk Ekle";
            this.btnMulkEkle.UseVisualStyleBackColor = true;
            this.btnMulkEkle.Click += new System.EventHandler(this.btnMulkEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblToplamGelir);
            this.groupBox1.Controls.Add(this.lblDukkanSayisi);
            this.groupBox1.Controls.Add(this.lblDaireSayisi);
            this.groupBox1.Controls.Add(this.lblToplamSayi);
            this.groupBox1.Location = new System.Drawing.Point(508, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 410);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sistem Durum Özeti";
            // 
            // lblToplamGelir
            // 
            this.lblToplamGelir.AutoSize = true;
            this.lblToplamGelir.Location = new System.Drawing.Point(72, 330);
            this.lblToplamGelir.Name = "lblToplamGelir";
            this.lblToplamGelir.Size = new System.Drawing.Size(188, 24);
            this.lblToplamGelir.TabIndex = 3;
            this.lblToplamGelir.Text = "Tahmini Gelir: 0 TL";
            // 
            // lblDukkanSayisi
            // 
            this.lblDukkanSayisi.AutoSize = true;
            this.lblDukkanSayisi.Location = new System.Drawing.Point(72, 259);
            this.lblDukkanSayisi.Name = "lblDukkanSayisi";
            this.lblDukkanSayisi.Size = new System.Drawing.Size(166, 24);
            this.lblDukkanSayisi.TabIndex = 2;
            this.lblDukkanSayisi.Text = "Dükkan Sayısı: 0 ";
            // 
            // lblDaireSayisi
            // 
            this.lblDaireSayisi.AutoSize = true;
            this.lblDaireSayisi.Location = new System.Drawing.Point(72, 161);
            this.lblDaireSayisi.Name = "lblDaireSayisi";
            this.lblDaireSayisi.Size = new System.Drawing.Size(139, 24);
            this.lblDaireSayisi.TabIndex = 1;
            this.lblDaireSayisi.Text = "Daire Sayısı: 0";
            // 
            // lblToplamSayi
            // 
            this.lblToplamSayi.AutoSize = true;
            this.lblToplamSayi.Location = new System.Drawing.Point(72, 80);
            this.lblToplamSayi.Name = "lblToplamSayi";
            this.lblToplamSayi.Size = new System.Drawing.Size(154, 24);
            this.lblToplamSayi.TabIndex = 0;
            this.lblToplamSayi.Text = "Toplam Mülk: 0";
            // 
            // FrmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 536);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAnaMenu";
            this.Text = "FrmAnaMenu";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnMulkEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDukkanSayisi;
        private System.Windows.Forms.Label lblDaireSayisi;
        private System.Windows.Forms.Label lblToplamSayi;
        private System.Windows.Forms.Label lblToplamGelir;
    }
}

