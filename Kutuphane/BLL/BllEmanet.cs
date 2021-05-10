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
   public class BllEmanet
    {
        DAL.DAL dl = new DAL.DAL();
        public List<EmanetVarlik> Emanet_iade()
        {
            OleDbDataReader dr = dl.DRVeriCek("Select * from Emanet", CommandType.Text); //DAL katmanı yardımıyla Emanet tablosundaki verilerimizi çekiyoruz.
            if (dr.HasRows)
            {
                List<EmanetVarlik> islem_kayit = new List<EmanetVarlik>();
                while (dr.Read())
                {
                    //tablodaki verileri çekip yukle listesine ekliyoruz. 
                    EmanetVarlik yukle = new EmanetVarlik {OgrenciID = int.Parse(dr["OgrenciID"].ToString()), KitapID = int.Parse(dr["KitapID"].ToString()), EmanetVermeTarihi =dr["EmanetVermeTarihi"].ToString(), EmanetAlmaTarihi =dr["EmanetAlmaTarihi"].ToString(), EmanetIslemTarihi =dr["EmanetIslemTarihi"].ToString(), Borc =dr["Borc"].ToString(), IslemTuru = dr["IslemTuru"].ToString()};

                    islem_kayit.Add(yukle);
                }
                return islem_kayit; //listeyi geri yolluyoruz.
            }

            return null;
        }

        DAL.DAL dl1 = new DAL.DAL();
        public int tablo_iade_duzenleme(int OgrenciID, int KitapID, string IslemTuru)
        {
            //almaverme tablosundaki verileri güncellemek için sorgumuzu gönderiyoruz.
            int Sonuc = dl1.EkleSilGuncelle("update Emanet set IslemTuru='" + IslemTuru + "' where OgrenciID=" + OgrenciID + " and KitapID = " + KitapID + "", System.Data.CommandType.Text);

            return Sonuc;
        }

        public List<EmanetVarlik> kayit_listeleme1(int OgrenciNo)
        {
            //listelemek istediğimiz verileri veritabanından çekiyoruz.
            OleDbDataReader dr = dl.DRVeriCek("Select * from Emanet where OgrenciID in (select OgrenciID from Ogrenci where OgrenciNo ='" + OgrenciNo + "') ", CommandType.Text);
            if (dr.HasRows)
            {
                //veritabanından çektiğimiz verileri liste olarak geri gönderiyoruz.
                List<EmanetVarlik> islem_kayit = new List<EmanetVarlik>();
                while (dr.Read())
                {



                    EmanetVarlik kaydet = new EmanetVarlik { OgrenciID= int.Parse(dr["OgrenciID"].ToString()),KitapID = int.Parse(dr["KitapID"].ToString()), EmanetVermeTarihi = dr["EmanetVermeTarihi"].ToString(), EmanetAlmaTarihi = dr["EmanetAlmaTarihi"].ToString(), EmanetIslemTarihi = dr["EmanetIslemTarihi"].ToString(), Borc= dr["Borc"].ToString(), IslemTuru = dr["IslemTuru"].ToString() };

                    islem_kayit.Add(kaydet);
                }
                return islem_kayit;
            }

            return null;
        }

        DAL.DAL dl2 = new DAL.DAL();
        public int emanet_islemi(int KitapID, int OgrenciID, DateTime EmanetVermeTarihi, DateTime EmanetAlmaTarihi, string IslemTuru)
        {
            //emanet vermek için almaverme tablosuna gerekli verileri yolluyoruz.
            int Sonuc = dl2.EkleSilGuncelle("insert into Emanet (KitapID,OgrenciID,EmanetVermeTarihi,EmanetAlmaTarihi,IslemTuru) values (" +  OgrenciID+ "," + KitapID + ",'" + EmanetVermeTarihi + "','" + EmanetAlmaTarihi + "','" + IslemTuru + "')", System.Data.CommandType.Text);
            return Sonuc;
        }


        DAL.DAL dl3 = new DAL.DAL();
        public List<EmanetVarlik> ogrenci_emanet_iade_listele(string deger)
        {
            //listelemek istediğimiz verileri veritabanından çekiyoruz.
            OleDbDataReader dr = dl3.DRVeriCek("Select * from Emanet where OgrenciID in (Select OgrenciID from Ogrenci where OgrenciNo='" + deger + "')", CommandType.Text);
            if (dr.HasRows)
            {
                //veritabanından çektiğimiz verileri liste olarak geri gönderiyoruz.
                List<EmanetVarlik> islem_kayit = new List<EmanetVarlik>();
                while (dr.Read())
                {
                    EmanetVarlik kayit_etme = new EmanetVarlik { OgrenciID = int.Parse(dr["OgrenciID"].ToString()), KitapID = int.Parse(dr["KitapID"].ToString()), EmanetVermeTarihi = dr["EmanetVermeTarihi"].ToString(), EmanetAlmaTarihi = dr["EmanetAlmaTarihi"].ToString(), EmanetIslemTarihi = dr["EmanetIslemTarihi"].ToString(), Borc = dr["Borc"].ToString(),IslemTuru = dr["IslemTuru"].ToString() };

                    islem_kayit.Add(kayit_etme);
                }
                return islem_kayit;
            }

            return null;
        }
        DAL.DAL dl4 = new DAL.DAL();
        public List<EmanetVarlik> kayit_listeleme2(string deger, string konum)
        {
            //listelemek istediğimiz verileri veritabanından çekiyoruz.
            //bu sefer çekmek istediğimiz sütunu da sorguya gönderiyoruz. 
            OleDbDataReader dr = dl4.DRVeriCek("Select * from Emanet where KitapID in (Select KitapID from Kitap where " + konum + " ='" + deger + "')", CommandType.Text);
            if (dr.HasRows)
            {
                //veritabanından çektiğimiz verileri liste olarak geri gönderiyoruz.
                List<EmanetVarlik> islem_kayit = new List<EmanetVarlik>();
                while (dr.Read())
                {
                    EmanetVarlik kayit_etme = new EmanetVarlik {OgrenciID = int.Parse(dr["OgrenciID"].ToString()), KitapID = int.Parse(dr["KitapID"].ToString()), EmanetVermeTarihi = dr["EmanetVermeTarihi"].ToString(), EmanetAlmaTarihi = dr["EmanetAlmaTarihi"].ToString(), EmanetIslemTarihi = dr["EmanetIslemTarihi"].ToString(), Borc = dr["Borc"].ToString(), IslemTuru = dr["IslemTuru"].ToString() };

                    islem_kayit.Add(kayit_etme);
                }
                return islem_kayit;
            }

            return null;
        }


    }
}
