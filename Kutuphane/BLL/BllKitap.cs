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
   public class BllKitap
    {
        DAL.DAL dl1 = new DAL.DAL();
        public List<KitapVarlik> KitapGoster()
        {
            //veritabanından kitap tablosundaki değerleri çekiyoruz.
            OleDbDataReader dr = dl1.DRVeriCek("SELECT * FROM Kitap", CommandType.Text);
            if (dr.HasRows)
            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                List<KitapVarlik> KitapVarlik = new List<KitapVarlik>();
                while (dr.Read())
                {
                    KitapVarlik kitap = new KitapVarlik { KitapID = int.Parse(dr["KitapID"].ToString()), KitapAdi = dr["KitapAdi"].ToString(), BarkodNo = dr["BarkodNo"].ToString(), YazarAdi = dr["YazarAdi"].ToString(), YayinEvi = dr["YayinEvi"].ToString(), KitapTuru = dr["KitapTuru"].ToString(),StokSayisi= int.Parse(dr["StokSayisi"].ToString()),SayfaSayisi= int.Parse(dr["SayfaSayisi"].ToString()),BasimYili=int.Parse(dr["BasimYili"].ToString()) };
                    KitapVarlik.Add(kitap);
                }
                return KitapVarlik;
            }

            return null;
        }

        DAL.DAL dl2 = new DAL.DAL();
        public List<KitapVarlik> KitapGoster(string deger, string konum)
        {
            //veritabanından kitap tablosundaki değerleri çekiyoruz.
            OleDbDataReader dr = dl2.DRVeriCek("SELECT * FROM Kitap WHERE " + konum + " ='" + deger + "'", CommandType.Text);
            if (dr.HasRows)
            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                //bu sefer çekmek istediğimiz sütunu da sorguya gönderiyoruz. 
                List<KitapVarlik> KitapVarlik = new List<KitapVarlik>();
                while (dr.Read())
                {
                    KitapVarlik kitap = new KitapVarlik { KitapID = int.Parse(dr["KitapID"].ToString()), KitapAdi = dr["KitapAdi"].ToString(),BarkodNo = dr["BarkodNo"].ToString() ,YazarAdi = dr["YazarAdi"].ToString(), YayinEvi = dr["YayinEvi"].ToString(),KitapTuru = dr["KitapTuru"].ToString(), StokSayisi = int.Parse(dr["StokSayisi"].ToString()), SayfaSayisi = int.Parse(dr["SayfaSayisi"].ToString()),BasimYili =int.Parse( dr["BasimYili"].ToString()) };
                    KitapVarlik.Add(kitap);
                }
                return KitapVarlik;
            }

            return null;
        }


        DAL.DAL dl3 = new DAL.DAL();
        public int KitapEkle(string KitapAdi,string BarkodNo, string YazarAdi, string YayinEvi, string KitapTuru,int StokSayisi,int SayfaSayisi,int BasimYili)
        {
            //kitap eklemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = dl3.EkleSilGuncelle("insert into Kitap (KitapAdi,BarkodNo,YazarAdi,YayinEvi,KitapTuru,StokSayisi,SayfaSayisi,BasimYili) values ('" + KitapAdi + "','" + BarkodNo + "','" + YazarAdi + "','" + YayinEvi + "','" + KitapTuru + "','" + StokSayisi + "','"+ SayfaSayisi + "','" + BasimYili + "')", System.Data.CommandType.Text);
            return sonuc;
        }

        DAL.DAL dl4 = new DAL.DAL();
        public int KitapGuncelle(int KitapID, string KitapAdi, string BarkodNo, string YazarAdi, string YayinEvi, string KitapTuru, int StokSayisi, int SayfaSayisi, int BasimYili)
        {
            //kitap güncellemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = dl4.EkleSilGuncelle("update Kitap set KitapAdi='" + KitapAdi + "', BarkodNo='" + BarkodNo + "', YazarAdi='" + YazarAdi + "', YayinEvi='" + YayinEvi + "', KitapTuru='" + KitapTuru + "', StokSayisi='" + StokSayisi + "', SayfaSayisi='" + SayfaSayisi + "', BasimYili='" + BasimYili + "' WHERE KitapID=" + KitapID + "", System.Data.CommandType.Text);
            return sonuc;
        }

        DAL.DAL dl5 = new DAL.DAL();

        public int KitapSil(int KitapID)
        {
            //kitap silmek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = dl5.EkleSilGuncelle("DELETE from Kitap where KitapID =" + KitapID + "", System.Data.CommandType.Text);
            return sonuc;
        }
    }
}
