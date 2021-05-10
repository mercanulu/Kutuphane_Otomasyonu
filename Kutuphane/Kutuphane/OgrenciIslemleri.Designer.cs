
namespace Kutuphane
{
    partial class OgrenciIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciIslemleri));
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ogr_ara = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ogr_ara = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_cinsiyet = new System.Windows.Forms.ComboBox();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_sinif = new System.Windows.Forms.TextBox();
            this.txt_uyeliktarihi = new System.Windows.Forms.TextBox();
            this.txt_dgmtarihi = new System.Windows.Forms.TextBox();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.txt_dgmyeri = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_tum = new System.Windows.Forms.Button();
            this.ogrlistele = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrlistele)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_anasayfa.Location = new System.Drawing.Point(825, 215);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(108, 44);
            this.btn_anasayfa.TabIndex = 0;
            this.btn_anasayfa.Text = "ANASAYFA";
            this.btn_anasayfa.UseVisualStyleBackColor = false;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btn_ogr_ara);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_ogr_ara);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 171);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ara";
            // 
            // btn_ogr_ara
            // 
            this.btn_ogr_ara.Location = new System.Drawing.Point(85, 89);
            this.btn_ogr_ara.Name = "btn_ogr_ara";
            this.btn_ogr_ara.Size = new System.Drawing.Size(151, 37);
            this.btn_ogr_ara.TabIndex = 4;
            this.btn_ogr_ara.Text = "Ara";
            this.btn_ogr_ara.UseVisualStyleBackColor = true;
            this.btn_ogr_ara.Click += new System.EventHandler(this.btn_ogr_ara_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Öğrenci No:";
            // 
            // txt_ogr_ara
            // 
            this.txt_ogr_ara.Location = new System.Drawing.Point(85, 41);
            this.txt_ogr_ara.Name = "txt_ogr_ara";
            this.txt_ogr_ara.Size = new System.Drawing.Size(151, 21);
            this.txt_ogr_ara.TabIndex = 2;
            this.txt_ogr_ara.Text = "Öğrenci numarası giriniz.";
            this.txt_ogr_ara.Click += new System.EventHandler(this.txt_ogr_ara_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.cmb_cinsiyet);
            this.groupBox2.Controls.Add(this.txt_adres);
            this.groupBox2.Controls.Add(this.txt_email);
            this.groupBox2.Controls.Add(this.txt_telefon);
            this.groupBox2.Controls.Add(this.txt_sinif);
            this.groupBox2.Controls.Add(this.txt_uyeliktarihi);
            this.groupBox2.Controls.Add(this.txt_dgmtarihi);
            this.groupBox2.Controls.Add(this.txt_no);
            this.groupBox2.Controls.Add(this.txt_dgmyeri);
            this.groupBox2.Controls.Add(this.txt_soyad);
            this.groupBox2.Controls.Add(this.txt_isim);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(282, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 245);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Bilgileri";
            // 
            // cmb_cinsiyet
            // 
            this.cmb_cinsiyet.FormattingEnabled = true;
            this.cmb_cinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmb_cinsiyet.Location = new System.Drawing.Point(358, 22);
            this.cmb_cinsiyet.Name = "cmb_cinsiyet";
            this.cmb_cinsiyet.Size = new System.Drawing.Size(140, 23);
            this.cmb_cinsiyet.TabIndex = 8;
            this.cmb_cinsiyet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_cinsiyet_MouseClick);
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(358, 195);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(143, 21);
            this.txt_adres.TabIndex = 20;
            this.txt_adres.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_adres_MouseClick);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(96, 189);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(143, 21);
            this.txt_email.TabIndex = 19;
            this.txt_email.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_email_MouseClick);
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(358, 162);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(143, 21);
            this.txt_telefon.TabIndex = 18;
            this.txt_telefon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_telefon_MouseClick);
            // 
            // txt_sinif
            // 
            this.txt_sinif.Location = new System.Drawing.Point(96, 155);
            this.txt_sinif.Name = "txt_sinif";
            this.txt_sinif.Size = new System.Drawing.Size(143, 21);
            this.txt_sinif.TabIndex = 17;
            this.txt_sinif.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_sinif_MouseClick);
            // 
            // txt_uyeliktarihi
            // 
            this.txt_uyeliktarihi.Location = new System.Drawing.Point(358, 132);
            this.txt_uyeliktarihi.Name = "txt_uyeliktarihi";
            this.txt_uyeliktarihi.Size = new System.Drawing.Size(143, 21);
            this.txt_uyeliktarihi.TabIndex = 16;
            this.txt_uyeliktarihi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_uyeliktarihi_MouseClick);
            // 
            // txt_dgmtarihi
            // 
            this.txt_dgmtarihi.Location = new System.Drawing.Point(358, 98);
            this.txt_dgmtarihi.Name = "txt_dgmtarihi";
            this.txt_dgmtarihi.Size = new System.Drawing.Size(143, 21);
            this.txt_dgmtarihi.TabIndex = 15;
            this.txt_dgmtarihi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_dgmtarihi_MouseClick);
            // 
            // txt_no
            // 
            this.txt_no.Location = new System.Drawing.Point(96, 125);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(143, 21);
            this.txt_no.TabIndex = 13;
            this.txt_no.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_no_MouseClick);
            // 
            // txt_dgmyeri
            // 
            this.txt_dgmyeri.Location = new System.Drawing.Point(358, 58);
            this.txt_dgmyeri.Name = "txt_dgmyeri";
            this.txt_dgmyeri.Size = new System.Drawing.Size(143, 21);
            this.txt_dgmyeri.TabIndex = 12;
            this.txt_dgmyeri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_dgmyeri_MouseClick);
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(96, 95);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(143, 21);
            this.txt_soyad.TabIndex = 11;
            this.txt_soyad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_soyad_MouseClick);
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(96, 65);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(143, 21);
            this.txt_isim.TabIndex = 10;
            this.txt_isim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_isim_MouseClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(297, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 15);
            this.label13.TabIndex = 4;
            this.label13.Text = "Adres:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(297, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Telefon:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "E-mail:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Sınıf:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cinsiyet:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Üyelik Tarihi:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(96, 33);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(143, 21);
            this.txt_id.TabIndex = 2;
            this.txt_id.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_id_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Doğum Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Öğrenci No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Öğrenci Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Doğum Yeri:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Öğrenci Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Öğrenci ID:";
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ekle.Location = new System.Drawing.Point(825, 14);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(108, 40);
            this.btn_ekle.TabIndex = 3;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_guncelle.Location = new System.Drawing.Point(825, 78);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(108, 40);
            this.btn_guncelle.TabIndex = 4;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sil.Location = new System.Drawing.Point(825, 149);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(108, 40);
            this.btn_sil.TabIndex = 5;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_tum
            // 
            this.btn_tum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_tum.Location = new System.Drawing.Point(14, 219);
            this.btn_tum.Name = "btn_tum";
            this.btn_tum.Size = new System.Drawing.Size(251, 40);
            this.btn_tum.TabIndex = 6;
            this.btn_tum.Text = "TÜM KAYITLARI GÖSTER";
            this.btn_tum.UseVisualStyleBackColor = false;
            this.btn_tum.Click += new System.EventHandler(this.btn_tum_Click);
            // 
            // ogrlistele
            // 
            this.ogrlistele.AllowUserToOrderColumns = true;
            this.ogrlistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrlistele.Location = new System.Drawing.Point(1, 331);
            this.ogrlistele.Name = "ogrlistele";
            this.ogrlistele.Size = new System.Drawing.Size(926, 297);
            this.ogrlistele.TabIndex = 7;
            this.ogrlistele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ogrlistele_CellContentClick);
            // 
            // OgrenciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(939, 646);
            this.Controls.Add(this.ogrlistele);
            this.Controls.Add(this.btn_tum);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_anasayfa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OgrenciIslemleri";
            this.Text = "Öğrenci İşlemleri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrlistele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ogr_ara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ogr_ara;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_sinif;
        private System.Windows.Forms.TextBox txt_uyeliktarihi;
        private System.Windows.Forms.TextBox txt_dgmtarihi;
        private System.Windows.Forms.TextBox txt_no;
        private System.Windows.Forms.TextBox txt_dgmyeri;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_tum;
        private System.Windows.Forms.ComboBox cmb_cinsiyet;
        private System.Windows.Forms.DataGridView ogrlistele;
    }
}