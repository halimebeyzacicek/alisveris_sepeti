namespace staj_3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.urun_sec_buton = new System.Windows.Forms.Button();
            this.birim_fiyati = new System.Windows.Forms.Label();
            this.birim_fiyat_label = new System.Windows.Forms.Label();
            this.adet_gir_label = new System.Windows.Forms.Label();
            this.urun_adi = new System.Windows.Forms.Label();
            this.urun_adet = new System.Windows.Forms.Label();
            this.birim_fiyat = new System.Windows.Forms.Label();
            this.tutar = new System.Windows.Forms.Label();
            this.adet_gir_text_box = new System.Windows.Forms.TextBox();
            this.sepete_ekle_buton = new System.Windows.Forms.Button();
            this.urun_adet_lb = new System.Windows.Forms.ListBox();
            this.tutar_lb = new System.Windows.Forms.ListBox();
            this.sepet_toplam = new System.Windows.Forms.Label();
            this.toplam = new System.Windows.Forms.TextBox();
            this.birim_fiyat_lb = new System.Windows.Forms.ListBox();
            this.secilen_label = new System.Windows.Forms.Label();
            this.secilen = new System.Windows.Forms.Label();
            this.urun_adi_clb = new System.Windows.Forms.CheckedListBox();
            this.sil_btn = new System.Windows.Forms.Button();
            this.odeme_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urun_sec_buton
            // 
            this.urun_sec_buton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.urun_sec_buton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.urun_sec_buton.Font = new System.Drawing.Font("Centaur", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urun_sec_buton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.urun_sec_buton.Location = new System.Drawing.Point(47, 31);
            this.urun_sec_buton.Name = "urun_sec_buton";
            this.urun_sec_buton.Size = new System.Drawing.Size(248, 116);
            this.urun_sec_buton.TabIndex = 0;
            this.urun_sec_buton.Text = "Ürün Seç";
            this.urun_sec_buton.UseVisualStyleBackColor = false;
            this.urun_sec_buton.Click += new System.EventHandler(this.button1_Click);
            // 
            // birim_fiyati
            // 
            this.birim_fiyati.AutoSize = true;
            this.birim_fiyati.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.birim_fiyati.Font = new System.Drawing.Font("Centaur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birim_fiyati.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.birim_fiyati.Location = new System.Drawing.Point(40, 269);
            this.birim_fiyati.Name = "birim_fiyati";
            this.birim_fiyati.Size = new System.Drawing.Size(166, 38);
            this.birim_fiyati.TabIndex = 1;
            this.birim_fiyati.Text = "Birim Fiyatı:";
            // 
            // birim_fiyat_label
            // 
            this.birim_fiyat_label.AutoSize = true;
            this.birim_fiyat_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.birim_fiyat_label.Font = new System.Drawing.Font("Centaur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birim_fiyat_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.birim_fiyat_label.Location = new System.Drawing.Point(241, 269);
            this.birim_fiyat_label.Name = "birim_fiyat_label";
            this.birim_fiyat_label.Size = new System.Drawing.Size(26, 38);
            this.birim_fiyat_label.TabIndex = 2;
            this.birim_fiyat_label.Text = "?";
            // 
            // adet_gir_label
            // 
            this.adet_gir_label.AutoSize = true;
            this.adet_gir_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adet_gir_label.Font = new System.Drawing.Font("Centaur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adet_gir_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adet_gir_label.Location = new System.Drawing.Point(40, 366);
            this.adet_gir_label.Name = "adet_gir_label";
            this.adet_gir_label.Size = new System.Drawing.Size(83, 38);
            this.adet_gir_label.TabIndex = 3;
            this.adet_gir_label.Text = "Adet:";
            // 
            // urun_adi
            // 
            this.urun_adi.AutoSize = true;
            this.urun_adi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.urun_adi.Font = new System.Drawing.Font("Centaur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urun_adi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.urun_adi.Location = new System.Drawing.Point(460, 34);
            this.urun_adi.Name = "urun_adi";
            this.urun_adi.Size = new System.Drawing.Size(134, 38);
            this.urun_adi.TabIndex = 4;
            this.urun_adi.Text = "Ürün Adı";
            // 
            // urun_adet
            // 
            this.urun_adet.AutoSize = true;
            this.urun_adet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.urun_adet.Font = new System.Drawing.Font("Centaur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urun_adet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.urun_adet.Location = new System.Drawing.Point(667, 34);
            this.urun_adet.Name = "urun_adet";
            this.urun_adet.Size = new System.Drawing.Size(76, 38);
            this.urun_adet.TabIndex = 5;
            this.urun_adet.Text = "Adet";
            // 
            // birim_fiyat
            // 
            this.birim_fiyat.AutoSize = true;
            this.birim_fiyat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.birim_fiyat.Font = new System.Drawing.Font("Centaur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birim_fiyat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.birim_fiyat.Location = new System.Drawing.Point(815, 34);
            this.birim_fiyat.Name = "birim_fiyat";
            this.birim_fiyat.Size = new System.Drawing.Size(151, 38);
            this.birim_fiyat.TabIndex = 6;
            this.birim_fiyat.Text = "Birim Fiyat";
            // 
            // tutar
            // 
            this.tutar.AutoSize = true;
            this.tutar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tutar.Font = new System.Drawing.Font("Centaur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tutar.Location = new System.Drawing.Point(1026, 34);
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(86, 38);
            this.tutar.TabIndex = 7;
            this.tutar.Text = "Tutar";
            // 
            // adet_gir_text_box
            // 
            this.adet_gir_text_box.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adet_gir_text_box.Font = new System.Drawing.Font("Centaur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adet_gir_text_box.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adet_gir_text_box.Location = new System.Drawing.Point(165, 363);
            this.adet_gir_text_box.Name = "adet_gir_text_box";
            this.adet_gir_text_box.Size = new System.Drawing.Size(130, 45);
            this.adet_gir_text_box.TabIndex = 8;
            this.adet_gir_text_box.TextChanged += new System.EventHandler(this.adet_gir_text_box_TextChanged);
            this.adet_gir_text_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adet_gir_text_box_KeyPress);
            // 
            // sepete_ekle_buton
            // 
            this.sepete_ekle_buton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sepete_ekle_buton.Font = new System.Drawing.Font("Centaur", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sepete_ekle_buton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sepete_ekle_buton.Location = new System.Drawing.Point(38, 464);
            this.sepete_ekle_buton.Name = "sepete_ekle_buton";
            this.sepete_ekle_buton.Size = new System.Drawing.Size(271, 118);
            this.sepete_ekle_buton.TabIndex = 9;
            this.sepete_ekle_buton.Text = "Sepete\r\n Ekle";
            this.sepete_ekle_buton.UseVisualStyleBackColor = false;
            this.sepete_ekle_buton.Click += new System.EventHandler(this.sepete_ekle_buton_Click);
            // 
            // urun_adet_lb
            // 
            this.urun_adet_lb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.urun_adet_lb.Font = new System.Drawing.Font("Centaur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urun_adet_lb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.urun_adet_lb.FormattingEnabled = true;
            this.urun_adet_lb.ItemHeight = 31;
            this.urun_adet_lb.Location = new System.Drawing.Point(631, 89);
            this.urun_adet_lb.Name = "urun_adet_lb";
            this.urun_adet_lb.Size = new System.Drawing.Size(158, 283);
            this.urun_adet_lb.TabIndex = 11;
            // 
            // tutar_lb
            // 
            this.tutar_lb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tutar_lb.Font = new System.Drawing.Font("Centaur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutar_lb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tutar_lb.FormattingEnabled = true;
            this.tutar_lb.ItemHeight = 31;
            this.tutar_lb.Location = new System.Drawing.Point(988, 89);
            this.tutar_lb.Name = "tutar_lb";
            this.tutar_lb.Size = new System.Drawing.Size(158, 283);
            this.tutar_lb.TabIndex = 13;
            // 
            // sepet_toplam
            // 
            this.sepet_toplam.AutoSize = true;
            this.sepet_toplam.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sepet_toplam.Font = new System.Drawing.Font("Centaur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sepet_toplam.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sepet_toplam.Location = new System.Drawing.Point(754, 427);
            this.sepet_toplam.Name = "sepet_toplam";
            this.sepet_toplam.Size = new System.Drawing.Size(193, 38);
            this.sepet_toplam.TabIndex = 14;
            this.sepet_toplam.Text = "Sepet Toplam:";
            // 
            // toplam
            // 
            this.toplam.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toplam.Font = new System.Drawing.Font("Centaur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toplam.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toplam.Location = new System.Drawing.Point(971, 424);
            this.toplam.Name = "toplam";
            this.toplam.Size = new System.Drawing.Size(175, 45);
            this.toplam.TabIndex = 15;
            this.toplam.TextChanged += new System.EventHandler(this.toplam_TextChanged);
            // 
            // birim_fiyat_lb
            // 
            this.birim_fiyat_lb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.birim_fiyat_lb.Font = new System.Drawing.Font("Centaur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birim_fiyat_lb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.birim_fiyat_lb.FormattingEnabled = true;
            this.birim_fiyat_lb.ItemHeight = 31;
            this.birim_fiyat_lb.Location = new System.Drawing.Point(812, 89);
            this.birim_fiyat_lb.Name = "birim_fiyat_lb";
            this.birim_fiyat_lb.Size = new System.Drawing.Size(158, 283);
            this.birim_fiyat_lb.TabIndex = 16;
            // 
            // secilen_label
            // 
            this.secilen_label.AutoSize = true;
            this.secilen_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.secilen_label.Font = new System.Drawing.Font("Centaur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secilen_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.secilen_label.Location = new System.Drawing.Point(40, 203);
            this.secilen_label.Name = "secilen_label";
            this.secilen_label.Size = new System.Drawing.Size(178, 38);
            this.secilen_label.TabIndex = 17;
            this.secilen_label.Text = "Seçilen Ürün:";
            // 
            // secilen
            // 
            this.secilen.AutoSize = true;
            this.secilen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.secilen.Font = new System.Drawing.Font("Centaur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secilen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.secilen.Location = new System.Drawing.Point(241, 203);
            this.secilen.Name = "secilen";
            this.secilen.Size = new System.Drawing.Size(26, 38);
            this.secilen.TabIndex = 18;
            this.secilen.Text = "?";
            // 
            // urun_adi_clb
            // 
            this.urun_adi_clb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.urun_adi_clb.Font = new System.Drawing.Font("Centaur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urun_adi_clb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.urun_adi_clb.FormattingEnabled = true;
            this.urun_adi_clb.Location = new System.Drawing.Point(454, 89);
            this.urun_adi_clb.Name = "urun_adi_clb";
            this.urun_adi_clb.Size = new System.Drawing.Size(158, 301);
            this.urun_adi_clb.TabIndex = 19;
            // 
            // sil_btn
            // 
            this.sil_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sil_btn.Font = new System.Drawing.Font("Centaur", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sil_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sil_btn.Location = new System.Drawing.Point(377, 464);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(248, 116);
            this.sil_btn.TabIndex = 21;
            this.sil_btn.Text = "Ürün Sil";
            this.sil_btn.UseVisualStyleBackColor = false;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // odeme_btn
            // 
            this.odeme_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.odeme_btn.Font = new System.Drawing.Font("Centaur", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odeme_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.odeme_btn.Location = new System.Drawing.Point(812, 500);
            this.odeme_btn.Name = "odeme_btn";
            this.odeme_btn.Size = new System.Drawing.Size(248, 117);
            this.odeme_btn.TabIndex = 22;
            this.odeme_btn.Text = "Ödeme";
            this.odeme_btn.UseVisualStyleBackColor = false;
            this.odeme_btn.Click += new System.EventHandler(this.odeme_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::staj_3.Properties.Resources.tarih2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.odeme_btn);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.urun_adi_clb);
            this.Controls.Add(this.secilen);
            this.Controls.Add(this.secilen_label);
            this.Controls.Add(this.birim_fiyat_lb);
            this.Controls.Add(this.toplam);
            this.Controls.Add(this.sepet_toplam);
            this.Controls.Add(this.tutar_lb);
            this.Controls.Add(this.urun_adet_lb);
            this.Controls.Add(this.sepete_ekle_buton);
            this.Controls.Add(this.adet_gir_text_box);
            this.Controls.Add(this.tutar);
            this.Controls.Add(this.birim_fiyat);
            this.Controls.Add(this.urun_adet);
            this.Controls.Add(this.urun_adi);
            this.Controls.Add(this.adet_gir_label);
            this.Controls.Add(this.birim_fiyat_label);
            this.Controls.Add(this.birim_fiyati);
            this.Controls.Add(this.urun_sec_buton);
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button urun_sec_buton;
        private System.Windows.Forms.Label birim_fiyati;
        private System.Windows.Forms.Label adet_gir_label;
        private System.Windows.Forms.Label urun_adi;
        private System.Windows.Forms.Label urun_adet;
        private System.Windows.Forms.Label birim_fiyat;
        private System.Windows.Forms.Label tutar;
        private System.Windows.Forms.TextBox adet_gir_text_box;
        private System.Windows.Forms.Button sepete_ekle_buton;
        private System.Windows.Forms.ListBox urun_adet_lb;
        private System.Windows.Forms.ListBox tutar_lb;
        private System.Windows.Forms.Label sepet_toplam;
        private System.Windows.Forms.TextBox toplam;
        private System.Windows.Forms.ListBox birim_fiyat_lb;
        private System.Windows.Forms.Label secilen_label;
        public System.Windows.Forms.Label secilen;
        public System.Windows.Forms.Label birim_fiyat_label;
        private System.Windows.Forms.CheckedListBox urun_adi_clb;
        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.Button odeme_btn;
    }
}

