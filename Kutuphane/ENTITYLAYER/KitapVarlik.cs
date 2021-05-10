using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER//VARLIK KATMANI
{
    //bu sınıfa diğer katmanlardan kolaylıkla erişilebilsin diye public tanımlanır.
    public class KitapVarlik
    {
        //Kitap varlığına ait değişkenler girildi.
       public int KitapID { get; set; }
       public string KitapAdi { get; set; }
       public string BarkodNo { get; set; }
       public string YazarAdi { get; set; }
       public string YayinEvi { get; set; }
       public string KitapTuru { get; set; }
       public int StokSayisi { get; set; }
       public int SayfaSayisi { get; set; }
       public int BasimYili { get; set; }

        //Yukarıdaki değişkenlere diğer form ve katmanlardan 
        //direkt ulaşamayacağımız için kapsülleme yapıldı.
        //public şeklinde oluşturduğumuz bu alanlar sayesinde 
        //değişkenlere ulaşmış olacağız.
      


    }
}
