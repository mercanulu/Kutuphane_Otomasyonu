using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITYLAYER;
using BLL;

namespace Kutuphane
{
    public partial class KitapIslemleri : Form
    {
        public KitapIslemleri()
        {
            InitializeComponent();
        }

        string  konum = " ";

        BllKitap Islem = new BllKitap();

        private void Btn_ekle_Click(object sender, EventArgs e)
        {
            //BL'daki kitap_islem sınıfındaki ktp_ekle fonksiyonu çaılştırılarak kitap ekleme işlemi yapılır.
            try
            {
                int sonuc = Islem.KitapEkle(Txt_ktpadi.Text, Txt_no.Text, Txt_yazar.Text, Txt_yayinev.Text, Txt_ktptur.Text, int.Parse(Txt_stok.Text), int.Parse(Txt_sayfa.Text), int.Parse(Txt_basimyili.Text));
                MessageBox.Show("Kitap Başarıyla Eklendi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen  bilgilerini  giriniz!");
            }
        }
        //BllKitap 

        BllKitap Islem2 = new BllKitap();

        void VeriCek()
        {
            //kitaplar listesinden sütun bilgilerini çekip datagridview'e aktarır.
            List<KitapVarlik> ktp = Islem2.KitapGoster();
            KitapListele.DataSource = ktp;
        }

        private void Btn_listele_Click(object sender, EventArgs e)
        {
            //veri_cek fonksiyonu ile tüm kitap bilgileri datagridview'e aktarılır.
            VeriCek();
            MessageBox.Show("Tüm kayıtlar listelendi");
        }

        BllKitap Islem3 = new BllKitap();

        private void Btn_guncelle_Click(object sender, EventArgs e)
        {

            //BL'daki kitap_islem sınıfındaki ktp_guncelle fonksiyonu çalıştırılarak kitap güncellleme işlemi yapılır.
            try
            {
                int Sonuc = Islem3.KitapGuncelle (int.Parse(Txt_ktpid.Text), Txt_ktpadi.Text, Txt_no.Text, Txt_yazar.Text,Txt_yayinev.Text,Txt_ktptur.Text,int.Parse(Txt_stok.Text) ,int.Parse(Txt_sayfa.Text), int.Parse(Txt_basimyili.Text));
                MessageBox.Show("Kitap başarıyla güncellendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen güncelleme bilgilerini doğru giriniz!");
            }
        }

        BllKitap Islem4 = new BllKitap();

        private void Btn_sil_Click(object sender, EventArgs e)
        {
            //BL'daki kitap_islem sınıfındaki ktp_sil fonksiyonu çalıştırılarak kitap silme işlemi yapılır.
            try
            {
                int Sonuc = Islem4.KitapSil(int.Parse(Txt_ktpid.Text));
                MessageBox.Show("Kitap başarıyla silindi");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen alanları doldurduğunuzdan veya doğru olduğundan emin olunuz!");
            }
        }

        private void KitapListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview'de tıklanan satırın bilgileri textbox'a aktarılır.
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = KitapListele.Rows[e.RowIndex];
                Txt_ktpid.Text = row.Cells[0].Value.ToString();
                Txt_ktpadi.Text = row.Cells[1].Value.ToString();
                Txt_no.Text = row.Cells[2].Value.ToString();
                Txt_yazar.Text = row.Cells[3].Value.ToString();
                Txt_yayinev.Text = row.Cells[4].Value.ToString();
                Txt_ktptur.Text = row.Cells[5].Value.ToString();
                Txt_stok.Text = row.Cells[6].Value.ToString();
                Txt_sayfa.Text = row.Cells[7].Value.ToString();
                Txt_basimyili.Text = row.Cells[8].Value.ToString();

            }
        }

        private void Cmb_kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            //konum değeri textbox içersindeki seçilen değere eşitlenir.
            konum = Cmb_kategori.SelectedItem.ToString();
        }

        private void Txt_kitap_ara_TextChanged(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            Txt_kitap_ara.Text = "";
        }

        private void Btn_kitap_ara_Click(object sender, EventArgs e)
        {
            //BL'daki kitap_islem sınıfından kitap_goster fonksiyonu çalıştırılarak kitap bilgileri
            //datagridview'e aktarılır.
            try
            {
                List<KitapVarlik> ktp2 = Islem2.KitapGoster(Txt_kitap_ara.Text, konum);
                KitapListele.DataSource = ktp2;
                MessageBox.Show("Arama sonuçları listelendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Alanları Doldurunuz!");
            }
        }

        private void Btn_anasayfa_Click(object sender, EventArgs e)
        {
            //anasayfaya dönüş butonu.
            Anasayfa anasayfam = new Anasayfa();
            anasayfam.Show();
            this.Hide();
        }

        private void Txt_kitap_ara_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            Txt_kitap_ara.Text = "";
        }

        private void Txt_ktpid_MouseClick(object sender, MouseEventArgs e)
        {
            Txt_ktpid.Text = "";
        }

        private void Txt_ktpadi_MouseClick(object sender, MouseEventArgs e)
        {
            Txt_ktpadi.Text = "";
        }

        private void Txt_no_MouseClick(object sender, MouseEventArgs e)
        {
            Txt_no.Text = "";
        }

        private void Txt_yazar_MouseClick(object sender, MouseEventArgs e)
        {
            Txt_yazar.Text = "";
        }

        private void Txt_yayinev_MouseClick(object sender, MouseEventArgs e)
        {
            Txt_yayinev.Text = "";
        }

        private void Txt_ktptur_MouseClick(object sender, MouseEventArgs e)
        {
            Txt_ktptur.Text = "";
        }

        private void Txt_stok_MouseClick(object sender, MouseEventArgs e)
        {
            Txt_stok.Text = "";
        }

        private void Txt_sayfa_MouseClick(object sender, MouseEventArgs e)
        {
            Txt_sayfa.Text = "";
        }

        private void Txt_basimyili_MouseClick(object sender, MouseEventArgs e)
        {
            Txt_basimyili.Text = "";
        }
    }
}
