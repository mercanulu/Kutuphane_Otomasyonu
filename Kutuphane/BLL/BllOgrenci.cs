using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using DAL;
using ENTITYLAYER;

namespace BLL
{
    public class BllOgrenci
    {
        DAL.DAL dl1 = new DAL.DAL();
        public List<OgrenciVarlik> OgrenciGoster()
        {
            //veritabanından kitap tablosundaki değerleri çekiyoruz.
            OleDbDataReader dr = dl1.DRVeriCek("SELECT * FROM Ogrenci", CommandType.Text);
            if (dr.HasRows)
            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                List<OgrenciVarlik> ogrenciler1 = new List<OgrenciVarlik>();
                while (dr.Read())
                {
                    OgrenciVarlik ogrnci = new OgrenciVarlik { OgrenciID = int.Parse(dr["OgrenciID"].ToString()), OgrenciAd = dr["OgrenciAd"].ToString(), OgrenciSoyad = dr["OgrenciSoyad"].ToString(), DogumYeri = dr["DogumYeri"].ToString(), OgrenciNo = dr["OgrenciNo"].ToString(), Cinsiyet = dr["Cinsiyet"].ToString(), DogumTarihi = dr["DogumTarihi"].ToString(), UyelikTarihi =dr["UyelikTarihi"].ToString(), Sinif = int.Parse(dr["Sinif"].ToString()), Telefon = dr["Telefon"].ToString(), Email = dr["Email"].ToString(), Adres = dr["Adres"].ToString() };
                    ogrenciler1.Add(ogrnci);
                }
                return ogrenciler1;
            }

            return null;
        }

      

        DAL.DAL dl2 = new DAL.DAL();
        public List<OgrenciVarlik> OgrenciGoster(string OgrenciNo)
        {
            //veritabanından kitap tablosundaki değerleri çekiyoruz.
            OleDbDataReader dr = dl2.DRVeriCek("SELECT * FROM Ogrenci WHERE OgrenciNo='" + OgrenciNo + "'", CommandType.Text);
            if (dr.HasRows)
            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                //bu sefer çekmek istediğimiz sütunu da sorguya gönderiyoruz. 
                List<OgrenciVarlik> ogrenciler1 = new List<OgrenciVarlik>();
                while (dr.Read())
                {
                    OgrenciVarlik ogrnci = new OgrenciVarlik { OgrenciID = int.Parse(dr["OgrenciID"].ToString()), OgrenciAd = dr["OgrenciAd"].ToString(), OgrenciSoyad = dr["OgrenciSoyad"].ToString(), DogumYeri = dr["DogumYeri"].ToString(), OgrenciNo = dr["OgrenciNo"].ToString(), Cinsiyet = dr["Cinsiyet"].ToString(), DogumTarihi = dr["DogumTarihi"].ToString(), UyelikTarihi = dr["UyelikTarihi"].ToString(), Sinif = int.Parse(dr["Sinif"].ToString()), Telefon = dr["Telefon"].ToString(), Email = dr["Email"].ToString(), Adres = dr["Adres"].ToString() };
                    ogrenciler1.Add(ogrnci);
                }
                return ogrenciler1;
            }

            return null;
        }

        DAL.DAL dl3 = new DAL.DAL();
        public int OgrenciEkle(string OgrenciAd, string OgrenciSoyad, string DogumYeri,string OgrenciNo, string Cinsiyet, string DogumTarihi, string UyelikTarihi, int Sinif, string Telefon, string Email, string Adres)
        {
            //öğrenci eklemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = dl3.EkleSilGuncelle("INSERT into Ogrenci (OgrenciAd,OgrenciSoyad, DogumYeri,OgrenciNo, Cinsiyet, DogumTarihi,UyelikTarihi,Sinif,Telefon,Email,Adres) VALUES ('" + OgrenciAd + "','" + OgrenciSoyad + "','"+ DogumYeri + "','"+ OgrenciNo+ "','"+ Cinsiyet+ "','"+ DogumTarihi+ "','"+ UyelikTarihi+ "','"+ Sinif+ "','"+ Telefon + "','"+ Email + "','" + Adres+ "')", System.Data.CommandType.Text);
            return sonuc;
        }

        DAL.DAL dl4 = new DAL.DAL();
        public int OgrenciGuncelle(int OgrenciID, string OgrenciAd, string OgrenciSoyad, string DogumYeri,string OgrenciNo, string Cinsiyet, string DogumTarihi, string UyelikTarihi, int Sinif, string Telefon, string Email, string Adres)
        {
            //öğrenci güncellemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = dl4.EkleSilGuncelle("UPDATE Ogrenci SET OgrenciAd='" + OgrenciAd + "', OgrenciSoyad='" + OgrenciSoyad+ "', DogumYeri='" + DogumYeri+ "', OgrenciNo='" + OgrenciNo+ "', Cinsiyet='" + Cinsiyet+ "', DogumTarihi='" + DogumTarihi+ "',UyelikTarihi='" + UyelikTarihi+ "',Sinif='" + Sinif+ "',Telefon='" + Telefon+ "',Email='" + Email + "', Adres='" + Adres + "' WHERE OgrenciID=" + OgrenciID + "", System.Data.CommandType.Text);
            return sonuc;
        }

        DAL.DAL dl5 = new DAL.DAL();

        public int OgrenciSil(int OgrenciID)
        {
            //öğrenciyi silmek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = dl5.EkleSilGuncelle("DELETE from Ogrenci where OgrenciID =" + OgrenciID + "", System.Data.CommandType.Text);
            return sonuc;
        }


    }
}
