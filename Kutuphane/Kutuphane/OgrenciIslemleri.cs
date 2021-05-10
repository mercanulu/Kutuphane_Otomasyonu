using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITYLAYER;

namespace Kutuphane
{
    public partial class OgrenciIslemleri : Form
    {
        public OgrenciIslemleri()
        {
            InitializeComponent();
        }

        BllOgrenci islem = new BllOgrenci();

        private void btn_ekle_Click(object sender, EventArgs e)
        {
           //BL'daki ogrenci_islem sınıfındaki ogr_ekle fonksiyonu çalıştırılarak öğrenci ekleme işlemi yapılır.
            int sonuc = islem.OgrenciEkle(txt_isim.Text, txt_soyad.Text, txt_dgmyeri.Text, txt_no.Text, cmb_cinsiyet.SelectedItem.ToString(), txt_dgmtarihi.Text, txt_uyeliktarihi.Text,int.Parse (txt_sinif.Text), txt_telefon.Text,txt_email.Text, txt_adres.Text);
            MessageBox.Show("Öğrenci Başarıyla Eklendi.");
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            //BL'daki ogrenci_islem sınıfındaki ogr_guncelle fonksiyonu çalıştırılarak öğrenci güncelleme işlemi yapılır.
            try
            {
                int sonuc = islem.OgrenciGuncelle(int.Parse(txt_id.Text), txt_isim.Text, txt_soyad.Text, txt_dgmyeri.Text,txt_no.Text, cmb_cinsiyet.Text,txt_dgmtarihi.Text,txt_uyeliktarihi.Text,int.Parse(txt_sinif.Text),txt_telefon.Text,txt_email.Text,txt_adres.Text);
                MessageBox.Show("Öğrenci Başarıyla Güncellendi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen güncelleme bilgilerini doğru girdiğinizden emin olun!");
            }
        }

        BllOgrenci islem2 = new BllOgrenci();
        private void btn_sil_Click(object sender, EventArgs e)
        {
            //BL'daki BLLOgrenci sınıfındaki OgrenciSil fonksiyonu çalıştırılarak öğrenci silme işlemi yapılır.
            try
            {
                islem2.OgrenciSil(int.Parse(txt_id.Text));
                MessageBox.Show("Öğrenci Başarıyla Silindi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen girilen değerleri kontrol ediniz!");
            }
        }

        BllOgrenci islem3 = new BllOgrenci();
        void ogr_gstr()
        {
            //ogrencilerrenciler listesindeki verileri ogr_goster fonkiyonu ile datagridview'e çağırır. 
            List<OgrenciVarlik> ogrenciler1 = islem3.OgrenciGoster();
            ogrlistele.DataSource = ogrenciler1;
        }

        private void btn_tum_Click(object sender, EventArgs e)
        {
            //ogr_gstr fonksiyonu ile öğrenci listelemesi yapılır.
            ogr_gstr();
            MessageBox.Show("Öğrenciler Başarıyla Listelendi.");
        }

        private void ogrlistele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview'de tıklanan satırın bilgileri textbox'a aktarılır.
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = ogrlistele.Rows[e.RowIndex];
                txt_id.Text = row.Cells[0].Value.ToString();
                txt_isim.Text = row.Cells[1].Value.ToString();
                txt_soyad.Text = row.Cells[2].Value.ToString();
                txt_dgmyeri.Text = row.Cells[3].Value.ToString();
                txt_no.Text = row.Cells[4].Value.ToString();
                cmb_cinsiyet.Text = row.Cells[5].Value.ToString();
                txt_dgmtarihi.Text = row.Cells[6].Value.ToString();
                txt_uyeliktarihi.Text = row.Cells[7].Value.ToString();
                txt_sinif.Text = row.Cells[8].Value.ToString();
                txt_telefon.Text = row.Cells[9].Value.ToString();
                txt_email.Text = row.Cells[10].Value.ToString();
                txt_adres.Text = row.Cells[11].Value.ToString();

            }
        }
        
        private void btn_ogr_ara_Click(object sender, EventArgs e)
        {
            
            // arama textbox'ındaki metin ogrenciler tablosundan bulunarak listeleniyor.

            List<OgrenciVarlik> ogrenciler1 = islem.OgrenciGoster(txt_ogr_ara.Text);
            ogrlistele.DataSource = ogrenciler1;
        }

        private void txt_ogr_ara_TextChanged(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            txt_ogr_ara.Text = "";
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            //anasayfaya dönüş butonu
            Anasayfa anasayfam = new Anasayfa();
            anasayfam.Show();
            this.Hide();
        }

        private void txt_ogr_ara_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            txt_ogr_ara.Text = "";
        }

        private void txt_id_MouseClick(object sender, MouseEventArgs e)
        {
            txt_id.Text = "";
        }

        private void txt_isim_MouseClick(object sender, MouseEventArgs e)
        {
            txt_isim.Text = "";
        }

        private void txt_soyad_MouseClick(object sender, MouseEventArgs e)
        {
            txt_soyad.Text = "";
        }

        private void txt_no_MouseClick(object sender, MouseEventArgs e)
        {
            txt_no.Text = "";
        }

        private void txt_sinif_MouseClick(object sender, MouseEventArgs e)
        {
            txt_sinif.Text = "";
        }

        private void txt_email_MouseClick(object sender, MouseEventArgs e)
        {
            txt_email.Text = "";
        }

        private void cmb_cinsiyet_MouseClick(object sender, MouseEventArgs e)
        {
            cmb_cinsiyet.Text = "";
        }

        private void txt_dgmyeri_MouseClick(object sender, MouseEventArgs e)
        {
            txt_dgmyeri.Text = "";
        }

        private void txt_dgmtarihi_MouseClick(object sender, MouseEventArgs e)
        {
            txt_dgmtarihi.Text = "";
        }

        private void txt_uyeliktarihi_MouseClick(object sender, MouseEventArgs e)
        {
            txt_uyeliktarihi.Text = "";
        }

        private void txt_telefon_MouseClick(object sender, MouseEventArgs e)
        {
            txt_telefon.Text = "";
        }

        private void txt_adres_MouseClick(object sender, MouseEventArgs e)
        {
            txt_adres.Text = "";
        }
    }
}