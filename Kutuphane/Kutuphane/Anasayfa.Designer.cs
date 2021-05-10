
namespace Kutuphane
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.btn_ogrenciislemi = new System.Windows.Forms.Button();
            this.Btn_kitapislemi = new System.Windows.Forms.Button();
            this.Btn_emanetislem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_OgrKitapListesi = new System.Windows.Forms.Button();
            this.Btn_Ogrtakip = new System.Windows.Forms.Button();
            this.Btn_grafik = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ogrenciislemi
            // 
            this.btn_ogrenciislemi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ogrenciislemi.BackgroundImage")));
            this.btn_ogrenciislemi.Location = new System.Drawing.Point(49, 120);
            this.btn_ogrenciislemi.Name = "btn_ogrenciislemi";
            this.btn_ogrenciislemi.Size = new System.Drawing.Size(137, 112);
            this.btn_ogrenciislemi.TabIndex = 0;
            this.btn_ogrenciislemi.UseVisualStyleBackColor = true;
            this.btn_ogrenciislemi.Click += new System.EventHandler(this.btn_ogrenciislemi_Click);
            // 
            // Btn_kitapislemi
            // 
            this.Btn_kitapislemi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_kitapislemi.BackgroundImage")));
            this.Btn_kitapislemi.Location = new System.Drawing.Point(227, 120);
            this.Btn_kitapislemi.Name = "Btn_kitapislemi";
            this.Btn_kitapislemi.Size = new System.Drawing.Size(137, 112);
            this.Btn_kitapislemi.TabIndex = 1;
            this.Btn_kitapislemi.UseVisualStyleBackColor = true;
            this.Btn_kitapislemi.Click += new System.EventHandler(this.Btn_kitapislemi_Click);
            // 
            // Btn_emanetislem
            // 
            this.Btn_emanetislem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_emanetislem.BackgroundImage")));
            this.Btn_emanetislem.Location = new System.Drawing.Point(417, 120);
            this.Btn_emanetislem.Name = "Btn_emanetislem";
            this.Btn_emanetislem.Size = new System.Drawing.Size(137, 112);
            this.Btn_emanetislem.TabIndex = 2;
            this.Btn_emanetislem.UseVisualStyleBackColor = true;
            this.Btn_emanetislem.Click += new System.EventHandler(this.Btn_emanetislem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(60, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ÖĞRENCİ İŞLEMLERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(253, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "KİTAP İŞLEMLERİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(415, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "EMANET-İADE İŞLEMLERİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(107, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(362, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "KÜTÜPHANE OTOMASYONUNA HOŞGELDİNİZ";
            // 
            // Btn_OgrKitapListesi
            // 
            this.Btn_OgrKitapListesi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_OgrKitapListesi.BackgroundImage")));
            this.Btn_OgrKitapListesi.Location = new System.Drawing.Point(49, 336);
            this.Btn_OgrKitapListesi.Name = "Btn_OgrKitapListesi";
            this.Btn_OgrKitapListesi.Size = new System.Drawing.Size(137, 112);
            this.Btn_OgrKitapListesi.TabIndex = 7;
            this.Btn_OgrKitapListesi.UseVisualStyleBackColor = true;
            this.Btn_OgrKitapListesi.Click += new System.EventHandler(this.Btn_OgrKitapListesi_Click);
            // 
            // Btn_Ogrtakip
            // 
            this.Btn_Ogrtakip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Ogrtakip.BackgroundImage")));
            this.Btn_Ogrtakip.Location = new System.Drawing.Point(227, 336);
            this.Btn_Ogrtakip.Name = "Btn_Ogrtakip";
            this.Btn_Ogrtakip.Size = new System.Drawing.Size(137, 112);
            this.Btn_Ogrtakip.TabIndex = 8;
            this.Btn_Ogrtakip.UseVisualStyleBackColor = true;
            this.Btn_Ogrtakip.Click += new System.EventHandler(this.Btn_Ogrtakip_Click);
            // 
            // Btn_grafik
            // 
            this.Btn_grafik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_grafik.BackgroundImage")));
            this.Btn_grafik.Location = new System.Drawing.Point(417, 336);
            this.Btn_grafik.Name = "Btn_grafik";
            this.Btn_grafik.Size = new System.Drawing.Size(137, 112);
            this.Btn_grafik.TabIndex = 9;
            this.Btn_grafik.UseVisualStyleBackColor = true;
            this.Btn_grafik.Click += new System.EventHandler(this.Btn_grafik_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(35, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "KİTAP EMANET-İADE LİSTESİ ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(211, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ÖĞRENCİ EMANET-İADE  LİSTESİ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(467, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "GRAFİK";
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(607, 533);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_grafik);
            this.Controls.Add(this.Btn_Ogrtakip);
            this.Controls.Add(this.Btn_OgrKitapListesi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_emanetislem);
            this.Controls.Add(this.Btn_kitapislemi);
            this.Controls.Add(this.btn_ogrenciislemi);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ogrenciislemi;
        private System.Windows.Forms.Button Btn_kitapislemi;
        private System.Windows.Forms.Button Btn_emanetislem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_OgrKitapListesi;
        private System.Windows.Forms.Button Btn_Ogrtakip;
        private System.Windows.Forms.Button Btn_grafik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

