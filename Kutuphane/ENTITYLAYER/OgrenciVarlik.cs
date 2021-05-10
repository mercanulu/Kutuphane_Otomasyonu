using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER//VARLIK KATMANI
{
    //Varlık sınıfı diğer katmanlardan kolaylıkla ulaşılabilsin diye public tanımlanır.
   public class OgrenciVarlik
    {
        //Öğrenciye ait değişkenler girildi.
        public int OgrenciID { get; set; }
        public string OgrenciAd { get; set; }
        public string OgrenciSoyad { get; set; }
        public string DogumYeri { get; set; }
        public string OgrenciNo { get; set; }
        public string Cinsiyet { get; set; }
        public string DogumTarihi { get; set; }
        public string UyelikTarihi { get; set; }
        public int Sinif { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }


        //Yukarıdaki değişkenlere diğer form ve katmanlardan 
        //direkt ulaşamayacağımız için kapsülleme yapıldı.
        //public şeklinde oluşturduğumuz bu alanlar sayesinde 
        //değişkenlere ulaşmış olacağız.
      


    }
}
