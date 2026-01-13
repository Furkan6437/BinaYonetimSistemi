
namespace BinaYonetimSistemi
{
    partial class FrmMulkEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDukkan = new System.Windows.Forms.RadioButton();
            this.rbDaire = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMetrekare = new System.Windows.Forms.TextBox();
            this.txtKat = new System.Windows.Forms.TextBox();
            this.txtKapiNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlOdaAlani = new System.Windows.Forms.Panel();
            this.cmbOdaSayisi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlOdaAlani.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDukkan);
            this.groupBox1.Controls.Add(this.rbDaire);
            this.groupBox1.Location = new System.Drawing.Point(57, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mülk Tipi";
            // 
            // rbDukkan
            // 
            this.rbDukkan.AutoSize = true;
            this.rbDukkan.Location = new System.Drawing.Point(37, 136);
            this.rbDukkan.Name = "rbDukkan";
            this.rbDukkan.Size = new System.Drawing.Size(174, 28);
            this.rbDukkan.TabIndex = 1;
            this.rbDukkan.TabStop = true;
            this.rbDukkan.Text = "Ticari (Dükkan)";
            this.rbDukkan.UseVisualStyleBackColor = true;
            this.rbDukkan.CheckedChanged += new System.EventHandler(this.rbDukkan_CheckedChanged);
            // 
            // rbDaire
            // 
            this.rbDaire.AutoSize = true;
            this.rbDaire.Location = new System.Drawing.Point(37, 83);
            this.rbDaire.Name = "rbDaire";
            this.rbDaire.Size = new System.Drawing.Size(157, 28);
            this.rbDaire.TabIndex = 0;
            this.rbDaire.TabStop = true;
            this.rbDaire.Text = "Konut (Daire)";
            this.rbDaire.UseVisualStyleBackColor = true;
            this.rbDaire.CheckedChanged += new System.EventHandler(this.rbDaire_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMetrekare);
            this.groupBox2.Controls.Add(this.txtKat);
            this.groupBox2.Controls.Add(this.txtKapiNo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(487, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 273);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilgiler";
            // 
            // txtMetrekare
            // 
            this.txtMetrekare.Location = new System.Drawing.Point(177, 148);
            this.txtMetrekare.Name = "txtMetrekare";
            this.txtMetrekare.Size = new System.Drawing.Size(100, 30);
            this.txtMetrekare.TabIndex = 5;
            // 
            // txtKat
            // 
            this.txtKat.Location = new System.Drawing.Point(177, 98);
            this.txtKat.Name = "txtKat";
            this.txtKat.Size = new System.Drawing.Size(100, 30);
            this.txtKat.TabIndex = 4;
            // 
            // txtKapiNo
            // 
            this.txtKapiNo.Location = new System.Drawing.Point(177, 50);
            this.txtKapiNo.Name = "txtKapiNo";
            this.txtKapiNo.Size = new System.Drawing.Size(100, 30);
            this.txtKapiNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Metrekare:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kat Numarası:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kapı Numarası:";
            // 
            // pnlOdaAlani
            // 
            this.pnlOdaAlani.BackColor = System.Drawing.Color.Gray;
            this.pnlOdaAlani.Controls.Add(this.cmbOdaSayisi);
            this.pnlOdaAlani.Controls.Add(this.label4);
            this.pnlOdaAlani.Location = new System.Drawing.Point(57, 291);
            this.pnlOdaAlani.Name = "pnlOdaAlani";
            this.pnlOdaAlani.Size = new System.Drawing.Size(755, 179);
            this.pnlOdaAlani.TabIndex = 2;
            // 
            // cmbOdaSayisi
            // 
            this.cmbOdaSayisi.FormattingEnabled = true;
            this.cmbOdaSayisi.Items.AddRange(new object[] {
            "1+1",
            "2+1",
            "3+1"});
            this.cmbOdaSayisi.Location = new System.Drawing.Point(282, 53);
            this.cmbOdaSayisi.Name = "cmbOdaSayisi";
            this.cmbOdaSayisi.Size = new System.Drawing.Size(121, 32);
            this.cmbOdaSayisi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Oda Sayısı:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(339, 476);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(153, 35);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FrmMulkEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 538);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.pnlOdaAlani);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMulkEkle";
            this.Text = "FrmMulkEkle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlOdaAlani.ResumeLayout(false);
            this.pnlOdaAlani.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDukkan;
        private System.Windows.Forms.RadioButton rbDaire;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMetrekare;
        private System.Windows.Forms.TextBox txtKat;
        private System.Windows.Forms.TextBox txtKapiNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlOdaAlani;
        private System.Windows.Forms.ComboBox cmbOdaSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKaydet;
    }
}