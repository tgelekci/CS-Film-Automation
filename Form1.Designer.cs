namespace FilmOtomasyonu
{
    partial class FormFilmOtomasyonu
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
            this.lblFilmAdi = new System.Windows.Forms.Label();
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblFilmTuru = new System.Windows.Forms.Label();
            this.txtFilmTuru = new System.Windows.Forms.TextBox();
            this.lblCikisYili = new System.Windows.Forms.Label();
            this.txtCikisYili = new System.Windows.Forms.TextBox();
            this.lblFilmSil = new System.Windows.Forms.Label();
            this.txtFilmSil = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblKirala = new System.Windows.Forms.Label();
            this.txtKirala = new System.Windows.Forms.TextBox();
            this.btnKirala = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblGun = new System.Windows.Forms.Label();
            this.lblBedel = new System.Windows.Forms.Label();
            this.txtGun = new System.Windows.Forms.TextBox();
            this.txtBedel = new System.Windows.Forms.TextBox();
            this.lblTeslim = new System.Windows.Forms.Label();
            this.txtTeslim = new System.Windows.Forms.TextBox();
            this.btnTeslim = new System.Windows.Forms.Button();
            this.lblDegisen = new System.Windows.Forms.Label();
            this.txtDegisen = new System.Windows.Forms.TextBox();
            this.lblYeniFilmAdi = new System.Windows.Forms.Label();
            this.txtYeniFilmAdi = new System.Windows.Forms.TextBox();
            this.lblYeniFilmCikis = new System.Windows.Forms.Label();
            this.txtYeniFilmCikis = new System.Windows.Forms.TextBox();
            this.lblYeniFilmTur = new System.Windows.Forms.Label();
            this.txtYeniFilmTur = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dgvBul = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kiralandimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CikisYili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBul)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilmAdi
            // 
            this.lblFilmAdi.AutoSize = true;
            this.lblFilmAdi.Location = new System.Drawing.Point(12, 26);
            this.lblFilmAdi.Name = "lblFilmAdi";
            this.lblFilmAdi.Size = new System.Drawing.Size(46, 13);
            this.lblFilmAdi.TabIndex = 0;
            this.lblFilmAdi.Text = "Film Adı:";
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.Location = new System.Drawing.Point(87, 23);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(383, 20);
            this.txtFilmAdi.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(395, 112);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblFilmTuru
            // 
            this.lblFilmTuru.AutoSize = true;
            this.lblFilmTuru.Location = new System.Drawing.Point(12, 50);
            this.lblFilmTuru.Name = "lblFilmTuru";
            this.lblFilmTuru.Size = new System.Drawing.Size(53, 13);
            this.lblFilmTuru.TabIndex = 3;
            this.lblFilmTuru.Text = "Film Türü:";
            // 
            // txtFilmTuru
            // 
            this.txtFilmTuru.Location = new System.Drawing.Point(87, 49);
            this.txtFilmTuru.Name = "txtFilmTuru";
            this.txtFilmTuru.Size = new System.Drawing.Size(383, 20);
            this.txtFilmTuru.TabIndex = 4;
            // 
            // lblCikisYili
            // 
            this.lblCikisYili.AutoSize = true;
            this.lblCikisYili.Location = new System.Drawing.Point(12, 77);
            this.lblCikisYili.Name = "lblCikisYili";
            this.lblCikisYili.Size = new System.Drawing.Size(69, 13);
            this.lblCikisYili.TabIndex = 5;
            this.lblCikisYili.Text = "Film Çıkış Yılı:";
            // 
            // txtCikisYili
            // 
            this.txtCikisYili.Location = new System.Drawing.Point(87, 77);
            this.txtCikisYili.Name = "txtCikisYili";
            this.txtCikisYili.Size = new System.Drawing.Size(383, 20);
            this.txtCikisYili.TabIndex = 6;
            // 
            // lblFilmSil
            // 
            this.lblFilmSil.AutoSize = true;
            this.lblFilmSil.Location = new System.Drawing.Point(12, 180);
            this.lblFilmSil.Name = "lblFilmSil";
            this.lblFilmSil.Size = new System.Drawing.Size(46, 13);
            this.lblFilmSil.TabIndex = 7;
            this.lblFilmSil.Text = "Film Adı:";
            // 
            // txtFilmSil
            // 
            this.txtFilmSil.Location = new System.Drawing.Point(87, 177);
            this.txtFilmSil.Name = "txtFilmSil";
            this.txtFilmSil.Size = new System.Drawing.Size(383, 20);
            this.txtFilmSil.TabIndex = 8;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(395, 218);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblKirala
            // 
            this.lblKirala.AutoSize = true;
            this.lblKirala.Location = new System.Drawing.Point(12, 279);
            this.lblKirala.Name = "lblKirala";
            this.lblKirala.Size = new System.Drawing.Size(46, 13);
            this.lblKirala.TabIndex = 10;
            this.lblKirala.Text = "Film Adı:";
            // 
            // txtKirala
            // 
            this.txtKirala.Location = new System.Drawing.Point(87, 276);
            this.txtKirala.Name = "txtKirala";
            this.txtKirala.Size = new System.Drawing.Size(383, 20);
            this.txtKirala.TabIndex = 11;
            // 
            // btnKirala
            // 
            this.btnKirala.Location = new System.Drawing.Point(386, 381);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(75, 23);
            this.btnKirala.TabIndex = 12;
            this.btnKirala.Text = "Kirala";
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(103, 381);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 13;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.Location = new System.Drawing.Point(12, 315);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(89, 13);
            this.lblGun.TabIndex = 14;
            this.lblGun.Text = "Kiralanacak Gün:";
            // 
            // lblBedel
            // 
            this.lblBedel.AutoSize = true;
            this.lblBedel.Location = new System.Drawing.Point(12, 343);
            this.lblBedel.Name = "lblBedel";
            this.lblBedel.Size = new System.Drawing.Size(79, 13);
            this.lblBedel.TabIndex = 15;
            this.lblBedel.Text = "Kira Bedeli(TL):";
            // 
            // txtGun
            // 
            this.txtGun.Location = new System.Drawing.Point(107, 312);
            this.txtGun.Name = "txtGun";
            this.txtGun.Size = new System.Drawing.Size(71, 20);
            this.txtGun.TabIndex = 16;
            // 
            // txtBedel
            // 
            this.txtBedel.Enabled = false;
            this.txtBedel.Location = new System.Drawing.Point(107, 340);
            this.txtBedel.Name = "txtBedel";
            this.txtBedel.Size = new System.Drawing.Size(71, 20);
            this.txtBedel.TabIndex = 17;
            // 
            // lblTeslim
            // 
            this.lblTeslim.AutoSize = true;
            this.lblTeslim.Location = new System.Drawing.Point(12, 449);
            this.lblTeslim.Name = "lblTeslim";
            this.lblTeslim.Size = new System.Drawing.Size(46, 13);
            this.lblTeslim.TabIndex = 18;
            this.lblTeslim.Text = "Film Adı:";
            // 
            // txtTeslim
            // 
            this.txtTeslim.Location = new System.Drawing.Point(87, 446);
            this.txtTeslim.Name = "txtTeslim";
            this.txtTeslim.Size = new System.Drawing.Size(383, 20);
            this.txtTeslim.TabIndex = 19;
            // 
            // btnTeslim
            // 
            this.btnTeslim.Location = new System.Drawing.Point(386, 497);
            this.btnTeslim.Name = "btnTeslim";
            this.btnTeslim.Size = new System.Drawing.Size(75, 23);
            this.btnTeslim.TabIndex = 20;
            this.btnTeslim.Text = "Teslim Et";
            this.btnTeslim.UseVisualStyleBackColor = true;
            this.btnTeslim.Click += new System.EventHandler(this.btnTeslim_Click);
            // 
            // lblDegisen
            // 
            this.lblDegisen.AutoSize = true;
            this.lblDegisen.Location = new System.Drawing.Point(12, 573);
            this.lblDegisen.Name = "lblDegisen";
            this.lblDegisen.Size = new System.Drawing.Size(100, 13);
            this.lblDegisen.TabIndex = 21;
            this.lblDegisen.Text = "Değişecek Film Adı:";
            // 
            // txtDegisen
            // 
            this.txtDegisen.Location = new System.Drawing.Point(118, 570);
            this.txtDegisen.Name = "txtDegisen";
            this.txtDegisen.Size = new System.Drawing.Size(352, 20);
            this.txtDegisen.TabIndex = 22;
            // 
            // lblYeniFilmAdi
            // 
            this.lblYeniFilmAdi.AutoSize = true;
            this.lblYeniFilmAdi.Location = new System.Drawing.Point(12, 606);
            this.lblYeniFilmAdi.Name = "lblYeniFilmAdi";
            this.lblYeniFilmAdi.Size = new System.Drawing.Size(70, 13);
            this.lblYeniFilmAdi.TabIndex = 23;
            this.lblYeniFilmAdi.Text = "Yeni Film Adı:";
            // 
            // txtYeniFilmAdi
            // 
            this.txtYeniFilmAdi.Location = new System.Drawing.Point(118, 606);
            this.txtYeniFilmAdi.Name = "txtYeniFilmAdi";
            this.txtYeniFilmAdi.Size = new System.Drawing.Size(352, 20);
            this.txtYeniFilmAdi.TabIndex = 24;
            // 
            // lblYeniFilmCikis
            // 
            this.lblYeniFilmCikis.AutoSize = true;
            this.lblYeniFilmCikis.Location = new System.Drawing.Point(12, 669);
            this.lblYeniFilmCikis.Name = "lblYeniFilmCikis";
            this.lblYeniFilmCikis.Size = new System.Drawing.Size(93, 13);
            this.lblYeniFilmCikis.TabIndex = 25;
            this.lblYeniFilmCikis.Text = "Yeni Film Çıkış Yılı:";
            // 
            // txtYeniFilmCikis
            // 
            this.txtYeniFilmCikis.Location = new System.Drawing.Point(118, 666);
            this.txtYeniFilmCikis.Name = "txtYeniFilmCikis";
            this.txtYeniFilmCikis.Size = new System.Drawing.Size(352, 20);
            this.txtYeniFilmCikis.TabIndex = 26;
            // 
            // lblYeniFilmTur
            // 
            this.lblYeniFilmTur.AutoSize = true;
            this.lblYeniFilmTur.Location = new System.Drawing.Point(11, 638);
            this.lblYeniFilmTur.Name = "lblYeniFilmTur";
            this.lblYeniFilmTur.Size = new System.Drawing.Size(77, 13);
            this.lblYeniFilmTur.TabIndex = 27;
            this.lblYeniFilmTur.Text = "Yeni Film Türü:";
            // 
            // txtYeniFilmTur
            // 
            this.txtYeniFilmTur.Location = new System.Drawing.Point(118, 635);
            this.txtYeniFilmTur.Name = "txtYeniFilmTur";
            this.txtYeniFilmTur.Size = new System.Drawing.Size(352, 20);
            this.txtYeniFilmTur.TabIndex = 28;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(386, 711);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 29;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dgvBul
            // 
            this.dgvBul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBul.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Kiralandimi,
            this.Tur,
            this.CikisYili});
            this.dgvBul.Enabled = false;
            this.dgvBul.Location = new System.Drawing.Point(518, 27);
            this.dgvBul.Name = "dgvBul";
            this.dgvBul.Size = new System.Drawing.Size(448, 659);
            this.dgvBul.TabIndex = 30;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Ad";
            this.Column1.HeaderText = "Ad";
            this.Column1.Name = "Column1";
            // 
            // Kiralandimi
            // 
            this.Kiralandimi.DataPropertyName = "Kiralandimi";
            this.Kiralandimi.HeaderText = "Kiralandı mı?";
            this.Kiralandimi.Name = "Kiralandimi";
            // 
            // Tur
            // 
            this.Tur.DataPropertyName = "Tur";
            this.Tur.HeaderText = "Tür";
            this.Tur.Name = "Tur";
            // 
            // CikisYili
            // 
            this.CikisYili.DataPropertyName = "CikisYili";
            this.CikisYili.HeaderText = "Çıkış Yılı";
            this.CikisYili.Name = "CikisYili";
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(891, 711);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(75, 23);
            this.btnGoster.TabIndex = 31;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // FormFilmOtomasyonu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 746);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.dgvBul);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtYeniFilmTur);
            this.Controls.Add(this.lblYeniFilmTur);
            this.Controls.Add(this.txtYeniFilmCikis);
            this.Controls.Add(this.lblYeniFilmCikis);
            this.Controls.Add(this.txtYeniFilmAdi);
            this.Controls.Add(this.lblYeniFilmAdi);
            this.Controls.Add(this.txtDegisen);
            this.Controls.Add(this.lblDegisen);
            this.Controls.Add(this.btnTeslim);
            this.Controls.Add(this.txtTeslim);
            this.Controls.Add(this.lblTeslim);
            this.Controls.Add(this.txtBedel);
            this.Controls.Add(this.txtGun);
            this.Controls.Add(this.lblBedel);
            this.Controls.Add(this.lblGun);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnKirala);
            this.Controls.Add(this.txtKirala);
            this.Controls.Add(this.lblKirala);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtFilmSil);
            this.Controls.Add(this.lblFilmSil);
            this.Controls.Add(this.txtCikisYili);
            this.Controls.Add(this.lblCikisYili);
            this.Controls.Add(this.txtFilmTuru);
            this.Controls.Add(this.lblFilmTuru);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtFilmAdi);
            this.Controls.Add(this.lblFilmAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormFilmOtomasyonu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Otomasyonu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilmAdi;
        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblFilmTuru;
        private System.Windows.Forms.TextBox txtFilmTuru;
        private System.Windows.Forms.Label lblCikisYili;
        private System.Windows.Forms.TextBox txtCikisYili;
        private System.Windows.Forms.Label lblFilmSil;
        private System.Windows.Forms.TextBox txtFilmSil;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblKirala;
        private System.Windows.Forms.TextBox txtKirala;
        private System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.Label lblBedel;
        private System.Windows.Forms.TextBox txtGun;
        private System.Windows.Forms.TextBox txtBedel;
        private System.Windows.Forms.Label lblTeslim;
        private System.Windows.Forms.TextBox txtTeslim;
        private System.Windows.Forms.Button btnTeslim;
        private System.Windows.Forms.Label lblDegisen;
        private System.Windows.Forms.TextBox txtDegisen;
        private System.Windows.Forms.Label lblYeniFilmAdi;
        private System.Windows.Forms.TextBox txtYeniFilmAdi;
        private System.Windows.Forms.Label lblYeniFilmCikis;
        private System.Windows.Forms.TextBox txtYeniFilmCikis;
        private System.Windows.Forms.Label lblYeniFilmTur;
        private System.Windows.Forms.TextBox txtYeniFilmTur;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dgvBul;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kiralandimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CikisYili;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

