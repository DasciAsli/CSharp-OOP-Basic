using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım6_Inheritence2.Classes
{
    class Kadın:Insan
    {
        public string KizlikSoyIsim { get; set; }
        public Kadın(string ad,string soyad,int _yas,bool _cinsiyet,string ksoyad)
        {
            Isim = ad;
            SoyIsim = soyad;
            Yas = _yas;
            Cinsiyet = _cinsiyet;
            KizlikSoyIsim = ksoyad;
        }

        public List<object> Listele()
        {
            return new List<object>()
            {
                Isim,SoyIsim,Yas,Cinsiyet,KizlikSoyIsim
            };

        }
    }
}
