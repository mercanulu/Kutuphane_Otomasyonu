using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace DAL
{
    public class DAL
    {
        //access veritabanında sorgu yapmak için bu fonkiyonu kullanıyoruz.
        private OleDbCommand SorguYaz(string Sorgu, CommandType SorguTipi)
        {
            AccessBaglantisi baglanti = new AccessBaglantisi();
            OleDbCommand cmd = baglanti.BaglantiKablosu.CreateCommand();
            cmd.CommandText = Sorgu;
            cmd.CommandType = SorguTipi;
            return cmd;
        }
        List<OleDbParameter> Parametreler = new List<OleDbParameter>();

        //veritabanına parametre eklemek için bu fonksiyonu kullanıyoruz.
        public void InputParametreEkle(string ParametreAdi, object ParametreDegeri)
        {
            OleDbParameter parametre = new OleDbParameter();
            parametre.ParameterName = ParametreAdi;
            parametre.Value = ParametreDegeri;
            Parametreler.Add(parametre);
        }
        public void OutParametreEkle(string ParametreAdi, object ParametreDegeri)
        {
            OleDbParameter parametre = new OleDbParameter();
            parametre.ParameterName = ParametreAdi;
            parametre.Value = ParametreDegeri;
            parametre.Direction = ParameterDirection.Output;
            Parametreler.Add(parametre);
        }
        //aldığımız parametreleri sorguya eklemek için bu fonksiyonu kullanıyoruz.
        private void ParametreleriSorguyaEkle(OleDbCommand CommandNesnesi)
        {
            CommandNesnesi.Parameters.AddRange(Parametreler.ToArray());
        }

        //parametrenin değerini almak için kullanıyoruz.
        public object ParametreDeğeriniGetir(string ParametreAdi)
        {
            foreach (var item in Parametreler)
            {
                if (item.ParameterName == ParametreAdi)
                {
                    return item.Value.ToString();
                }
            }
            return null;
        }

        //veritabanında ekleme, silme ve güncelleme sorgularını bu fonksiyon ile gerçekleştiriyoruz.
        public int EkleSilGuncelle(string Sorgu, CommandType SorguTipi)
        {
            try
            {
                OleDbCommand cmd = SorguYaz(Sorgu, SorguTipi);
                ParametreleriSorguyaEkle(cmd);
                int sonuc = cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                cmd.Connection.Dispose();
                cmd.Dispose();
                return sonuc;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public object IlkSatirIlkSutun(string Sorgu, CommandType SorguTipi)
        {

            try
            {
                OleDbCommand cmd = SorguYaz(Sorgu, SorguTipi);
                ParametreleriSorguyaEkle(cmd);
                object Sonuc = cmd.ExecuteScalar();
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                cmd.Connection.Dispose();
                cmd.Dispose();
                return Sonuc;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //veritabanından veri çekme sorgularını bu fonksiyon ile yapıyoruz.
        public OleDbDataReader DRVeriCek(string Sorgu, CommandType SorguTipi)
        {
            OleDbCommand cmd = SorguYaz(Sorgu, SorguTipi);
            ParametreleriSorguyaEkle(cmd);
            OleDbDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }

        public DataTable DTVeriCek(string Sorgu, CommandType SorguTipi)
        {
            try
            {
                OleDbDataReader dr = DRVeriCek(Sorgu, SorguTipi);
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
