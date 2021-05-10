using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER//VARLIK KATMANI
{
    //bu sınıfa diğer katmanlardan kolaylıkla erişilebilsin diye public tanımlanır.
    public class EmanetVarlik
    {
       
        public int OgrenciID { get; set; }
        public int KitapID { get; set; }
        public string EmanetVermeTarihi { get; set; }
        public string EmanetAlmaTarihi { get; set; }
        public string EmanetIslemTarihi { get; set; }
        public string Borc { get; set; }
        public string IslemTuru { get; set; }

        //Yukarıdaki değişkenlere diğer form ve katmanlardan 
        //direkt ulaşamayacağımız için kapsülleme yapıldı.
        //public şeklinde oluşturduğumuz bu alanlar sayesinde 
        //değişkenlere ulaşmış olacağız.
       
    }
}
