using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Configuration;

namespace DAL
{
    public class AccessBaglantisi
    {
        //access veritabanı bağlantısı yapıldı.
        OleDbConnection baglanti;
        public OleDbConnection BaglantiKablosu
        {
            get
            {
                if (baglanti != null)
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    return baglanti;
                }
                else
                {
                    baglanti = new OleDbConnection(Provider());
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    return baglanti;
                }

            }
        }

        //App.config'den veritabanı adresimizi almak için bir bağlantı cümlesi oluşturuyoruz.
        private string Provider()
        {
            return Baglanti.BAGLANTI;
        }
    }
}
//Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\mercan ulu\\Kutuphane1.mdb