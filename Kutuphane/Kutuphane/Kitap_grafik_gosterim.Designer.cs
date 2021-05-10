
namespace Kutuphane
{
    partial class Kitap_grafik_gosterim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitap_grafik_gosterim));
            this.Btn_anasayfa = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // Btn_anasayfa
            // 
            this.Btn_anasayfa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_anasayfa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_anasayfa.Location = new System.Drawing.Point(12, 12);
            this.Btn_anasayfa.Name = "Btn_anasayfa";
            this.Btn_anasayfa.Size = new System.Drawing.Size(125, 42);
            this.Btn_anasayfa.TabIndex = 9;
            this.Btn_anasayfa.Text = "ANASAYFA";
            this.Btn_anasayfa.UseVisualStyleBackColor = false;
            this.Btn_anasayfa.Click += new System.EventHandler(this.Btn_anasayfa_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 88);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(673, 309);
            this.zedGraphControl1.TabIndex = 10;
            // 
            // Kitap_grafik_gosterim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(698, 426);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.Btn_anasayfa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kitap_grafik_gosterim";
            this.Text = "Kitap Grafiği";
            this.Load += new System.EventHandler(this.Kitap_grafik_gosterim_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_anasayfa;
        private ZedGraph.ZedGraphControl zedGraphControl1;
    }
}