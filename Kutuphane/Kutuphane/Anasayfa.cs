using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btn_ogrenciislemi_Click(object sender, EventArgs e)
        {
           OgrenciIslemleri ogrislem = new OgrenciIslemleri();
           ogrislem.Show();
           this.Hide();
        }

        private void Btn_kitapislemi_Click(object sender, EventArgs e)
        {
            KitapIslemleri ktpislem = new KitapIslemleri();
            ktpislem.Show();
            this.Hide();
        }

        private void Btn_emanetislem_Click(object sender, EventArgs e)
        {
            Emanet emanet_islem = new Emanet();
            emanet_islem.Show();
            this.Hide();
        }

        private void Btn_OgrKitapListesi_Click(object sender, EventArgs e)
        {
            Emanet_gosterim emanet_list = new Emanet_gosterim();
            emanet_list.Show();
            this.Hide();
        }

        private void Btn_Ogrtakip_Click(object sender, EventArgs e)
        {
            Ogrenci_emanet ogr_list = new Ogrenci_emanet();
            ogr_list.Show();
            this.Hide();
        }

        private void Btn_grafik_Click(object sender, EventArgs e)
        {
            Kitap_grafik_gosterim kitap_grafik = new Kitap_grafik_gosterim();
            kitap_grafik.Show();
            this.Hide();
        }
    }
}
