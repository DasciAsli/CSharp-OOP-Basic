using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım6_Inheritance.Classes
{
    /// <summary>
    /// Base sınıfı Hayvanlar olan bir derived sınıftır Tavuk sınıfı
    /// </summary>
    class Tavuk : Hayvanlar
    {
        
        public string Ibik { get; set; }
        public Tavuk(string name, int age, bool gender, string comb)
        {
            this.Ad = name;
            this.Yas = age;
            this.Cinsiyet = gender;
            this.Ibik = comb;
        }
        public List<Object> Listele()
        {
            return new List<object>()
            {
                Ad , Yas , Cinsiyet ,Ibik
            };
        }
    }
}
