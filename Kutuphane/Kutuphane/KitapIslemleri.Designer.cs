
namespace Kutuphane
{
    partial class KitapIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapIslemleri));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_kitap_ara = new System.Windows.Forms.Button();
            this.Txt_kitap_ara = new System.Windows.Forms.TextBox();
            this.Cmb_kategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_basimyili = new System.Windows.Forms.TextBox();
            this.Txt_sayfa = new System.Windows.Forms.TextBox();
            this.Txt_stok = new System.Windows.Forms.TextBox();
            this.Txt_ktptur = new System.Windows.Forms.TextBox();
            this.Txt_yayinev = new System.Windows.Forms.TextBox();
            this.Txt_yazar = new System.Windows.Forms.TextBox();
            this.Txt_no = new System.Windows.Forms.TextBox();
            this.Txt_ktpadi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_ktpid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_ekle = new System.Windows.Forms.Button();
            this.Btn_guncelle = new System.Windows.Forms.Button();
            this.Btn_sil = new System.Windows.Forms.Button();
            this.Btn_anasayfa = new System.Windows.Forms.Button();
            this.Btn_listele = new System.Windows.Forms.Button();
            this.KitapListele = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KitapListele)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.Btn_kitap_ara);
            this.groupBox1.Controls.Add(this.Txt_kitap_ara);
            this.groupBox1.Controls.Add(this.Cmb_kategori);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(22, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Ara";
            // 
            // Btn_kitap_ara
            // 
            this.Btn_kitap_ara.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_kitap_ara.Location = new System.Drawing.Point(23, 162);
            this.Btn_kitap_ara.Name = "Btn_kitap_ara";
            this.Btn_kitap_ara.Size = new System.Drawing.Size(155, 33);
            this.Btn_kitap_ara.TabIndex = 3;
            this.Btn_kitap_ara.Text = "Ara";
            this.Btn_kitap_ara.UseVisualStyleBackColor = false;
            this.Btn_kitap_ara.Click += new System.EventHandler(this.Btn_kitap_ara_Click);
            // 
            // Txt_kitap_ara
            // 
            this.Txt_kitap_ara.Location = new System.Drawing.Point(23, 108);
            this.Txt_kitap_ara.Name = "Txt_kitap_ara";
            this.Txt_kitap_ara.Size = new System.Drawing.Size(155, 22);
            this.Txt_kitap_ara.TabIndex = 2;
            this.Txt_kitap_ara.Text = "Kitap bilgisi girin";
            this.Txt_kitap_ara.Click += new System.EventHandler(this.Txt_kitap_ara_Click);
            // 
            // Cmb_kategori
            // 
            this.Cmb_kategori.FormattingEnabled = true;
            this.Cmb_kategori.Items.AddRange(new object[] {
            "KitapAdi",
            "BarkodNo",
            "YazarAdi",
            "YayinEvi",
            "KitapTuru",
            "StokSayisi",
            "SayfaSayisi",
            "BasimYili"});
            this.Cmb_kategori.Location = new System.Drawing.Point(23, 67);
            this.Cmb_kategori.Name = "Cmb_kategori";
            this.Cmb_kategori.Size = new System.Drawing.Size(155, 23);
            this.Cmb_kategori.TabIndex = 1;
            this.Cmb_kategori.SelectedIndexChanged += new System.EventHandler(this.Cmb_kategori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama kriterini seçiniz";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.Txt_basimyili);
            this.groupBox2.Controls.Add(this.Txt_sayfa);
            this.groupBox2.Controls.Add(this.Txt_stok);
            this.groupBox2.Controls.Add(this.Txt_ktptur);
            this.groupBox2.Controls.Add(this.Txt_yayinev);
            this.groupBox2.Controls.Add(this.Txt_yazar);
            this.groupBox2.Controls.Add(this.Txt_no);
            this.groupBox2.Controls.Add(this.Txt_ktpadi);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Txt_ktpid);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(241, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 322);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Bilgileri";
            // 
            // Txt_basimyili
            // 
            this.Txt_basimyili.Location = new System.Drawing.Point(79, 286);
            this.Txt_basimyili.Name = "Txt_basimyili";
            this.Txt_basimyili.Size = new System.Drawing.Size(201, 21);
            this.Txt_basimyili.TabIndex = 2;
            this.Txt_basimyili.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_basimyili_MouseClick);
            // 
            // Txt_sayfa
            // 
            this.Txt_sayfa.Location = new System.Drawing.Point(79, 256);
            this.Txt_sayfa.Name = "Txt_sayfa";
            this.Txt_sayfa.Size = new System.Drawing.Size(201, 21);
            this.Txt_sayfa.TabIndex = 2;
            this.Txt_sayfa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_sayfa_MouseClick);
            // 
            // Txt_stok
            // 
            this.Txt_stok.Location = new System.Drawing.Point(79, 224);
            this.Txt_stok.Name = "Txt_stok";
            this.Txt_stok.Size = new System.Drawing.Size(201, 21);
            this.Txt_stok.TabIndex = 15;
            this.Txt_stok.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_stok_MouseClick);
            // 
            // Txt_ktptur
            // 
            this.Txt_ktptur.Location = new System.Drawing.Point(79, 193);
            this.Txt_ktptur.Name = "Txt_ktptur";
            this.Txt_ktptur.Size = new System.Drawing.Size(201, 21);
            this.Txt_ktptur.TabIndex = 14;
            this.Txt_ktptur.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_ktptur_MouseClick);
            // 
            // Txt_yayinev
            // 
            this.Txt_yayinev.Location = new System.Drawing.Point(79, 163);
            this.Txt_yayinev.Name = "Txt_yayinev";
            this.Txt_yayinev.Size = new System.Drawing.Size(201, 21);
            this.Txt_yayinev.TabIndex = 13;
            this.Txt_yayinev.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_yayinev_MouseClick);
            // 
            // Txt_yazar
            // 
            this.Txt_yazar.Location = new System.Drawing.Point(79, 132);
            this.Txt_yazar.Name = "Txt_yazar";
            this.Txt_yazar.Size = new System.Drawing.Size(201, 21);
            this.Txt_yazar.TabIndex = 12;
            this.Txt_yazar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_yazar_MouseClick);
            // 
            // Txt_no
            // 
            this.Txt_no.Location = new System.Drawing.Point(79, 98);
            this.Txt_no.Name = "Txt_no";
            this.Txt_no.Size = new System.Drawing.Size(201, 21);
            this.Txt_no.TabIndex = 11;
            this.Txt_no.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_no_MouseClick);
            // 
            // Txt_ktpadi
            // 
            this.Txt_ktpadi.Location = new System.Drawing.Point(79, 65);
            this.Txt_ktpadi.Name = "Txt_ktpadi";
            this.Txt_ktpadi.Size = new System.Drawing.Size(201, 21);
            this.Txt_ktpadi.TabIndex = 10;
            this.Txt_ktpadi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_ktpadi_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Basım Yılı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Sayfa Sayısı:";
            // 
            // Txt_ktpid
            // 
            this.Txt_ktpid.Location = new System.Drawing.Point(79, 28);
            this.Txt_ktpid.Name = "Txt_ktpid";
            this.Txt_ktpid.Size = new System.Drawing.Size(201, 21);
            this.Txt_ktpid.TabIndex = 1;
            this.Txt_ktpid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_ktpid_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Stok Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kitap ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kitap Türü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitap Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yayın Evi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Barkod No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yazar Adı:";
            // 
            // Btn_ekle
            // 
            this.Btn_ekle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_ekle.Location = new System.Drawing.Point(565, 33);
            this.Btn_ekle.Name = "Btn_ekle";
            this.Btn_ekle.Size = new System.Drawing.Size(126, 40);
            this.Btn_ekle.TabIndex = 2;
            this.Btn_ekle.Text = "EKLE";
            this.Btn_ekle.UseVisualStyleBackColor = false;
            this.Btn_ekle.Click += new System.EventHandler(this.Btn_ekle_Click);
            // 
            // Btn_guncelle
            // 
            this.Btn_guncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_guncelle.Location = new System.Drawing.Point(565, 124);
            this.Btn_guncelle.Name = "Btn_guncelle";
            this.Btn_guncelle.Size = new System.Drawing.Size(126, 40);
            this.Btn_guncelle.TabIndex = 3;
            this.Btn_guncelle.Text = "GÜNCELLE";
            this.Btn_guncelle.UseVisualStyleBackColor = false;
            this.Btn_guncelle.Click += new System.EventHandler(this.Btn_guncelle_Click);
            // 
            // Btn_sil
            // 
            this.Btn_sil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_sil.Location = new System.Drawing.Point(565, 219);
            this.Btn_sil.Name = "Btn_sil";
            this.Btn_sil.Size = new System.Drawing.Size(126, 40);
            this.Btn_sil.TabIndex = 4;
            this.Btn_sil.Text = "SİL";
            this.Btn_sil.UseVisualStyleBackColor = false;
            this.Btn_sil.Click += new System.EventHandler(this.Btn_sil_Click);
            // 
            // Btn_anasayfa
            // 
            this.Btn_anasayfa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_anasayfa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_anasayfa.Location = new System.Drawing.Point(22, 26);
            this.Btn_anasayfa.Name = "Btn_anasayfa";
            this.Btn_anasayfa.Size = new System.Drawing.Size(201, 40);
            this.Btn_anasayfa.TabIndex = 5;
            this.Btn_anasayfa.Text = "ANASAYFA";
            this.Btn_anasayfa.UseVisualStyleBackColor = false;
            this.Btn_anasayfa.Click += new System.EventHandler(this.Btn_anasayfa_Click);
            // 
            // Btn_listele
            // 
            this.Btn_listele.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_listele.Location = new System.Drawing.Point(565, 308);
            this.Btn_listele.Name = "Btn_listele";
            this.Btn_listele.Size = new System.Drawing.Size(126, 40);
            this.Btn_listele.TabIndex = 6;
            this.Btn_listele.Text = "TÜM KAYITLARI GÖSTER";
            this.Btn_listele.UseVisualStyleBackColor = false;
            this.Btn_listele.Click += new System.EventHandler(this.Btn_listele_Click);
            // 
            // KitapListele
            // 
            this.KitapListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KitapListele.Location = new System.Drawing.Point(22, 394);
            this.KitapListele.Name = "KitapListele";
            this.KitapListele.Size = new System.Drawing.Size(701, 150);
            this.KitapListele.TabIndex = 7;
            this.KitapListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KitapListele_CellContentClick);
            // 
            // KitapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(743, 567);
            this.Controls.Add(this.KitapListele);
            this.Controls.Add(this.Btn_listele);
            this.Controls.Add(this.Btn_anasayfa);
            this.Controls.Add(this.Btn_sil);
            this.Controls.Add(this.Btn_guncelle);
            this.Controls.Add(this.Btn_ekle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitapIslemleri";
            this.Text = "Kitap İşlemleri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KitapListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Cmb_kategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_kitap_ara;
        private System.Windows.Forms.TextBox Txt_kitap_ara;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_basimyili;
        private System.Windows.Forms.TextBox Txt_sayfa;
        private System.Windows.Forms.TextBox Txt_stok;
        private System.Windows.Forms.TextBox Txt_ktptur;
        private System.Windows.Forms.TextBox Txt_yayinev;
        private System.Windows.Forms.TextBox Txt_yazar;
        private System.Windows.Forms.TextBox Txt_no;
        private System.Windows.Forms.TextBox Txt_ktpadi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_ktpid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_ekle;
        private System.Windows.Forms.Button Btn_guncelle;
        private System.Windows.Forms.Button Btn_sil;
        private System.Windows.Forms.Button Btn_anasayfa;
        private System.Windows.Forms.Button Btn_listele;
        private System.Windows.Forms.DataGridView KitapListele;
    }
}