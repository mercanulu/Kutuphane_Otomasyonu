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
    public partial class Emanet_gosterim : Form
    {
        public Emanet_gosterim()
        {
            InitializeComponent();
        }
        BllEmanet iade_ve_alim = new BllEmanet();
        private void Btn_ara_Click(object sender, EventArgs e)
        {
            //arama fonksiyonunda sorgu yapıp dönen liste değerlerini datagridview'e ekliyoruz.
            try
            {
                string konum = " ";
                konum = Cmb_Secenek.SelectedItem.ToString();
                List<EmanetVarlik> kayit_cekme = iade_ve_alim.kayit_listeleme2(Txt_bilgi_giris.Text, konum);
                data_listele.DataSource = kayit_cekme;
                MessageBox.Show("Arama başarılı!");
            }
            //eğer arama bölümü boş veya geçersiz ise hata mesajı veriyoruz.
            catch (Exception)
            {
                MessageBox.Show("Giriş değerlerini kontrol ediniz!");
            }
        }

        public void emanet_iade_renk()
        {
            double ceza;
            for (int i = 0; i < data_listele.Rows.Count; i++)
            {
                //ceza = double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());

                string islem_turu = data_listele.Rows[i].Cells[6].Value.ToString();

                //eğer islem_turu iade'ye eşitse ilgili satırlar yeşil olur.
                if (islem_turu == "iade")
                {
                    data_listele.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    data_listele.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }

                //almaverme tablosundaki islem_turu iadeye eşit değilse tarihsel işlemler aşağıdaki gibi yapılır.
                if (islem_turu != "iade")
                {
                    string t1, t2; DateTime s1, s2;
                    t1 = DateTime.Now.ToShortDateString();
                    DateTime t3 = DateTime.Parse(data_listele.Rows[i].Cells[3].Value.ToString());
                    t2 = t3.ToShortDateString();
                    TimeSpan fark;
                    s1 = DateTime.Parse(t1);
                    s2 = DateTime.Parse(t2);
                    fark = s1.Subtract(s2);

                    //eğer iade tarihine 3 gün veya daha az kaldıysa o kişinin satırı sarı olarak görünür
                    if (Int32.Parse(fark.TotalDays.ToString()) > -3 && Int32.Parse(fark.TotalDays.ToString()) < 1)
                    {
                        data_listele.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        data_listele.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    //eğer son iade tarihi geçmişse satırın kırmızı görünmesi sağlanır.
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        data_listele.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        data_listele.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        ceza = int.Parse(fark.TotalDays.ToString()) * 1;
                        data_listele.Rows[i].Cells[5].Value = ceza.ToString("c");
                    }
                }


            }
        }
        private void Btn_kayit_yukle_Click(object sender, EventArgs e)
        {
            //veritabanından almaverme'deki tüm verileri çekip datagridview'e yazıyoruz.
            List<EmanetVarlik> kitap = iade_ve_alim.Emanet_iade();
            data_listele.DataSource = kitap;
            emanet_iade_renk();
            MessageBox.Show("Kayıt gösterme Başarılı!");
        }

        private void Btn_anasayfa_Click(object sender, EventArgs e)
        {
            //anasayfaya dönüş butonu.
            Anasayfa anasyf = new Anasayfa();
            anasyf.Show();
            this.Hide();
        }

        private void Cmb_Secenek_MouseClick(object sender, MouseEventArgs e)
        {
            Cmb_Secenek.Text = "";
        }

        private void Txt_bilgi_giris_MouseClick(object sender, MouseEventArgs e)
        {
           Txt_bilgi_giris.Text = "";
        }
    }
}
