﻿
namespace Kutuphane
{
    partial class Emanet_gosterim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emanet_gosterim));
            this.Btn_anasayfa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_ara = new System.Windows.Forms.Button();
            this.Txt_bilgi_giris = new System.Windows.Forms.TextBox();
            this.Cmb_Secenek = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_kayit_yukle = new System.Windows.Forms.Button();
            this.data_listele = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_listele)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_anasayfa
            // 
            this.Btn_anasayfa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_anasayfa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_anasayfa.Location = new System.Drawing.Point(3, 12);
            this.Btn_anasayfa.Name = "Btn_anasayfa";
            this.Btn_anasayfa.Size = new System.Drawing.Size(122, 42);
            this.Btn_anasayfa.TabIndex = 7;
            this.Btn_anasayfa.Text = "ANASAYFA";
            this.Btn_anasayfa.UseVisualStyleBackColor = false;
            this.Btn_anasayfa.Click += new System.EventHandler(this.Btn_anasayfa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.Btn_ara);
            this.groupBox1.Controls.Add(this.Txt_bilgi_giris);
            this.groupBox1.Controls.Add(this.Cmb_Secenek);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(134, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 177);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet-İade Edilen Kitap";
            // 
            // Btn_ara
            // 
            this.Btn_ara.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_ara.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_ara.Location = new System.Drawing.Point(190, 110);
            this.Btn_ara.Name = "Btn_ara";
            this.Btn_ara.Size = new System.Drawing.Size(293, 37);
            this.Btn_ara.TabIndex = 4;
            this.Btn_ara.Text = "ARA";
            this.Btn_ara.UseVisualStyleBackColor = false;
            this.Btn_ara.Click += new System.EventHandler(this.Btn_ara_Click);
            // 
            // Txt_bilgi_giris
            // 
            this.Txt_bilgi_giris.Location = new System.Drawing.Point(190, 70);
            this.Txt_bilgi_giris.Name = "Txt_bilgi_giris";
            this.Txt_bilgi_giris.Size = new System.Drawing.Size(293, 22);
            this.Txt_bilgi_giris.TabIndex = 3;
            this.Txt_bilgi_giris.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_bilgi_giris_MouseClick);
            // 
            // Cmb_Secenek
            // 
            this.Cmb_Secenek.FormattingEnabled = true;
            this.Cmb_Secenek.Items.AddRange(new object[] {
            "KitapAdi",
            "BarkodNo",
            "YazarAdi",
            "YayinEvi",
            "KitapTuru",
            "StokSayisi",
            "SayfaSayisi",
            "BasimYili"});
            this.Cmb_Secenek.Location = new System.Drawing.Point(190, 26);
            this.Cmb_Secenek.Name = "Cmb_Secenek";
            this.Cmb_Secenek.Size = new System.Drawing.Size(293, 23);
            this.Cmb_Secenek.TabIndex = 2;
            this.Cmb_Secenek.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cmb_Secenek_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Bilgisi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Aratma Seçeneğini Belirtin:";
            // 
            // Btn_kayit_yukle
            // 
            this.Btn_kayit_yukle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_kayit_yukle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_kayit_yukle.Location = new System.Drawing.Point(3, 68);
            this.Btn_kayit_yukle.Name = "Btn_kayit_yukle";
            this.Btn_kayit_yukle.Size = new System.Drawing.Size(122, 45);
            this.Btn_kayit_yukle.TabIndex = 9;
            this.Btn_kayit_yukle.Text = "TÜM KAYITLARI GÖSTER";
            this.Btn_kayit_yukle.UseVisualStyleBackColor = false;
            this.Btn_kayit_yukle.Click += new System.EventHandler(this.Btn_kayit_yukle_Click);
            // 
            // data_listele
            // 
            this.data_listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_listele.Location = new System.Drawing.Point(3, 244);
            this.data_listele.Name = "data_listele";
            this.data_listele.Size = new System.Drawing.Size(636, 228);
            this.data_listele.TabIndex = 10;
            // 
            // Emanet_gosterim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(654, 493);
            this.Controls.Add(this.data_listele);
            this.Controls.Add(this.Btn_kayit_yukle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_anasayfa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Emanet_gosterim";
            this.Text = "Kitap Emanet-İade Listesi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_listele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_anasayfa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_bilgi_giris;
        private System.Windows.Forms.ComboBox Cmb_Secenek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_ara;
        private System.Windows.Forms.Button Btn_kayit_yukle;
        private System.Windows.Forms.DataGridView data_listele;
    }
}