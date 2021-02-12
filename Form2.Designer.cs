namespace staj_3
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.ad_label = new System.Windows.Forms.Label();
            this.yas_label = new System.Windows.Forms.Label();
            this.malzeme_label = new System.Windows.Forms.Label();
            this.ulke_label = new System.Windows.Forms.Label();
            this.b_fiyat_label = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.TextBox();
            this.yas = new System.Windows.Forms.TextBox();
            this.malzeme = new System.Windows.Forms.TextBox();
            this.ulke = new System.Windows.Forms.TextBox();
            this.b_fiyat = new System.Windows.Forms.TextBox();
            this.sec_buton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.antikaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antikaAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antikaYasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antikaMalzemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antikaUlkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antikaBirimFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antikaResimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAntikalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbo_antikaDataSet = new staj_3.dbo_antikaDataSet();
            this.tbl_AntikalarTableAdapter = new staj_3.dbo_antikaDataSetTableAdapters.Tbl_AntikalarTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.geri_don_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAntikalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_antikaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ad_label
            // 
            this.ad_label.AutoSize = true;
            this.ad_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ad_label.Font = new System.Drawing.Font("Centaur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ad_label.Location = new System.Drawing.Point(15, 22);
            this.ad_label.Name = "ad_label";
            this.ad_label.Size = new System.Drawing.Size(82, 45);
            this.ad_label.TabIndex = 0;
            this.ad_label.Text = "Adı:";
            // 
            // yas_label
            // 
            this.yas_label.AutoSize = true;
            this.yas_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yas_label.Font = new System.Drawing.Font("Centaur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yas_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.yas_label.Location = new System.Drawing.Point(12, 76);
            this.yas_label.Name = "yas_label";
            this.yas_label.Size = new System.Drawing.Size(99, 45);
            this.yas_label.TabIndex = 1;
            this.yas_label.Text = "Yaşı:";
            // 
            // malzeme_label
            // 
            this.malzeme_label.AutoSize = true;
            this.malzeme_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.malzeme_label.Font = new System.Drawing.Font("Centaur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malzeme_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.malzeme_label.Location = new System.Drawing.Point(12, 138);
            this.malzeme_label.Name = "malzeme_label";
            this.malzeme_label.Size = new System.Drawing.Size(162, 45);
            this.malzeme_label.TabIndex = 2;
            this.malzeme_label.Text = "Malzeme:";
            // 
            // ulke_label
            // 
            this.ulke_label.AutoSize = true;
            this.ulke_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ulke_label.Font = new System.Drawing.Font("Centaur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulke_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ulke_label.Location = new System.Drawing.Point(12, 197);
            this.ulke_label.Name = "ulke_label";
            this.ulke_label.Size = new System.Drawing.Size(100, 45);
            this.ulke_label.TabIndex = 3;
            this.ulke_label.Text = "Ülke:";
            // 
            // b_fiyat_label
            // 
            this.b_fiyat_label.AutoSize = true;
            this.b_fiyat_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_fiyat_label.Font = new System.Drawing.Font("Centaur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_fiyat_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b_fiyat_label.Location = new System.Drawing.Point(14, 264);
            this.b_fiyat_label.Name = "b_fiyat_label";
            this.b_fiyat_label.Size = new System.Drawing.Size(192, 45);
            this.b_fiyat_label.TabIndex = 4;
            this.b_fiyat_label.Text = "Birim Fiyat:";
            // 
            // ad
            // 
            this.ad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ad.Font = new System.Drawing.Font("Centaur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ad.Location = new System.Drawing.Point(238, 14);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(226, 53);
            this.ad.TabIndex = 5;
            // 
            // yas
            // 
            this.yas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yas.Font = new System.Drawing.Font("Centaur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.yas.Location = new System.Drawing.Point(238, 73);
            this.yas.Name = "yas";
            this.yas.Size = new System.Drawing.Size(226, 53);
            this.yas.TabIndex = 6;
            // 
            // malzeme
            // 
            this.malzeme.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.malzeme.Font = new System.Drawing.Font("Centaur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malzeme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.malzeme.Location = new System.Drawing.Point(238, 138);
            this.malzeme.Name = "malzeme";
            this.malzeme.Size = new System.Drawing.Size(226, 53);
            this.malzeme.TabIndex = 7;
            // 
            // ulke
            // 
            this.ulke.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ulke.Font = new System.Drawing.Font("Centaur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulke.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ulke.Location = new System.Drawing.Point(238, 197);
            this.ulke.Name = "ulke";
            this.ulke.Size = new System.Drawing.Size(226, 53);
            this.ulke.TabIndex = 8;
            // 
            // b_fiyat
            // 
            this.b_fiyat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_fiyat.Font = new System.Drawing.Font("Centaur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_fiyat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b_fiyat.Location = new System.Drawing.Point(238, 261);
            this.b_fiyat.Name = "b_fiyat";
            this.b_fiyat.Size = new System.Drawing.Size(226, 53);
            this.b_fiyat.TabIndex = 9;
            this.b_fiyat.Text = " ";
            // 
            // sec_buton
            // 
            this.sec_buton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sec_buton.Font = new System.Drawing.Font("Centaur", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sec_buton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sec_buton.Location = new System.Drawing.Point(12, 514);
            this.sec_buton.Name = "sec_buton";
            this.sec_buton.Size = new System.Drawing.Size(143, 127);
            this.sec_buton.TabIndex = 10;
            this.sec_buton.Text = "Seç";
            this.sec_buton.UseVisualStyleBackColor = false;
            this.sec_buton.Click += new System.EventHandler(this.sec_buton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.antikaIdDataGridViewTextBoxColumn,
            this.antikaAdDataGridViewTextBoxColumn,
            this.antikaYasDataGridViewTextBoxColumn,
            this.antikaMalzemeDataGridViewTextBoxColumn,
            this.antikaUlkeDataGridViewTextBoxColumn,
            this.antikaBirimFiyatDataGridViewTextBoxColumn,
            this.antikaResimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblAntikalarBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(315, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(755, 312);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // antikaIdDataGridViewTextBoxColumn
            // 
            this.antikaIdDataGridViewTextBoxColumn.DataPropertyName = "AntikaId";
            this.antikaIdDataGridViewTextBoxColumn.HeaderText = "AntikaId";
            this.antikaIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.antikaIdDataGridViewTextBoxColumn.Name = "antikaIdDataGridViewTextBoxColumn";
            this.antikaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.antikaIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // antikaAdDataGridViewTextBoxColumn
            // 
            this.antikaAdDataGridViewTextBoxColumn.DataPropertyName = "AntikaAd";
            this.antikaAdDataGridViewTextBoxColumn.HeaderText = "AntikaAd";
            this.antikaAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.antikaAdDataGridViewTextBoxColumn.Name = "antikaAdDataGridViewTextBoxColumn";
            this.antikaAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // antikaYasDataGridViewTextBoxColumn
            // 
            this.antikaYasDataGridViewTextBoxColumn.DataPropertyName = "AntikaYas";
            this.antikaYasDataGridViewTextBoxColumn.HeaderText = "AntikaYas";
            this.antikaYasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.antikaYasDataGridViewTextBoxColumn.Name = "antikaYasDataGridViewTextBoxColumn";
            this.antikaYasDataGridViewTextBoxColumn.Width = 125;
            // 
            // antikaMalzemeDataGridViewTextBoxColumn
            // 
            this.antikaMalzemeDataGridViewTextBoxColumn.DataPropertyName = "AntikaMalzeme";
            this.antikaMalzemeDataGridViewTextBoxColumn.HeaderText = "AntikaMalzeme";
            this.antikaMalzemeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.antikaMalzemeDataGridViewTextBoxColumn.Name = "antikaMalzemeDataGridViewTextBoxColumn";
            this.antikaMalzemeDataGridViewTextBoxColumn.Width = 125;
            // 
            // antikaUlkeDataGridViewTextBoxColumn
            // 
            this.antikaUlkeDataGridViewTextBoxColumn.DataPropertyName = "AntikaUlke";
            this.antikaUlkeDataGridViewTextBoxColumn.HeaderText = "AntikaUlke";
            this.antikaUlkeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.antikaUlkeDataGridViewTextBoxColumn.Name = "antikaUlkeDataGridViewTextBoxColumn";
            this.antikaUlkeDataGridViewTextBoxColumn.Width = 125;
            // 
            // antikaBirimFiyatDataGridViewTextBoxColumn
            // 
            this.antikaBirimFiyatDataGridViewTextBoxColumn.DataPropertyName = "AntikaBirimFiyat";
            this.antikaBirimFiyatDataGridViewTextBoxColumn.HeaderText = "AntikaBirimFiyat";
            this.antikaBirimFiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.antikaBirimFiyatDataGridViewTextBoxColumn.Name = "antikaBirimFiyatDataGridViewTextBoxColumn";
            this.antikaBirimFiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // antikaResimDataGridViewTextBoxColumn
            // 
            this.antikaResimDataGridViewTextBoxColumn.DataPropertyName = "AntikaResim";
            this.antikaResimDataGridViewTextBoxColumn.HeaderText = "AntikaResim";
            this.antikaResimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.antikaResimDataGridViewTextBoxColumn.Name = "antikaResimDataGridViewTextBoxColumn";
            this.antikaResimDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblAntikalarBindingSource
            // 
            this.tblAntikalarBindingSource.DataMember = "Tbl_Antikalar";
            this.tblAntikalarBindingSource.DataSource = this.dbo_antikaDataSet;
            // 
            // dbo_antikaDataSet
            // 
            this.dbo_antikaDataSet.DataSetName = "dbo_antikaDataSet";
            this.dbo_antikaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_AntikalarTableAdapter
            // 
            this.tbl_AntikalarTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(534, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 184);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sağda bulunan \r\npanel üzerinden \r\nürün seçimi \r\nyapabilirsiniz.";
            // 
            // geri_don_button
            // 
            this.geri_don_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.geri_don_button.Font = new System.Drawing.Font("Centaur", 28.2F);
            this.geri_don_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.geri_don_button.Location = new System.Drawing.Point(161, 514);
            this.geri_don_button.Name = "geri_don_button";
            this.geri_don_button.Size = new System.Drawing.Size(143, 127);
            this.geri_don_button.TabIndex = 15;
            this.geri_don_button.Text = "Geri\r\nDön";
            this.geri_don_button.UseVisualStyleBackColor = false;
            this.geri_don_button.Click += new System.EventHandler(this.geri_don_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::staj_3.Properties.Resources.tarih2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.geri_don_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sec_buton);
            this.Controls.Add(this.b_fiyat);
            this.Controls.Add(this.ulke);
            this.Controls.Add(this.malzeme);
            this.Controls.Add(this.yas);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.b_fiyat_label);
            this.Controls.Add(this.ulke_label);
            this.Controls.Add(this.malzeme_label);
            this.Controls.Add(this.yas_label);
            this.Controls.Add(this.ad_label);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAntikalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_antikaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ad_label;
        private System.Windows.Forms.Label yas_label;
        private System.Windows.Forms.Label malzeme_label;
        private System.Windows.Forms.Label ulke_label;
        private System.Windows.Forms.Label b_fiyat_label;
        private System.Windows.Forms.TextBox yas;
        private System.Windows.Forms.TextBox malzeme;
        private System.Windows.Forms.TextBox ulke;
        private System.Windows.Forms.Button sec_buton;
        public System.Windows.Forms.TextBox ad;
        public System.Windows.Forms.TextBox b_fiyat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbo_antikaDataSet dbo_antikaDataSet;
        private System.Windows.Forms.BindingSource tblAntikalarBindingSource;
        private dbo_antikaDataSetTableAdapters.Tbl_AntikalarTableAdapter tbl_AntikalarTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn antikaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn antikaAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn antikaYasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn antikaMalzemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn antikaUlkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn antikaBirimFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn antikaResimDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button geri_don_button;
    }
}