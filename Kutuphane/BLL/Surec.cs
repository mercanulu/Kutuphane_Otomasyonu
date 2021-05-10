using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITYLAYER;
using System.Data;
using System.Data.OleDb;

namespace BLL
{
   public class Surec
    {
        DAL.DAL dl = new DAL.DAL();
        public int Listele()
        {
            //veritabanından kitap sayılarını bir sayaçta tutup geri döndürüyoruz.
            int sayac = 0;
            OleDbDataReader dr = dl.DRVeriCek("Select KitapID from Kitap", CommandType.Text);
            if (dr.HasRows)
            {
                List<KitapVarlik> kitaplar = new List<KitapVarlik>();
                while (dr.Read())
                {
                    sayac++;
                }
                return sayac;
            }

            return 0;
        }

        DAL.DAL d2 = new DAL.DAL();
        public int alma()
        {
            //veritabanında işlem türü alım olan verilerin sayısını bir sayaçta tutup geri döndürüyoruz.
            int sayac = 0;
            OleDbDataReader dr = dl.DRVeriCek("Select * from Emanet where IslemTuru='" + "alım" + "'", CommandType.Text);
            if (dr.HasRows)
            {
                List<KitapVarlik> kitaplar = new List<KitapVarlik>();
                while (dr.Read())
                {
                    sayac++;
                }
                return sayac;
            }

            return 0;
        }
    }
}
