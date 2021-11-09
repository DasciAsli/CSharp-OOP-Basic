using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım12_AbstractClass2.Classes
{
    abstract class Kitap
    {
        public abstract string KitapAd { get; set; }
        public abstract string KitapYazar { get; set; }
        public abstract int SatisAdet();
        public List<object> Listele()
        {
            return new List<object>()
            {
                KitapAd,KitapYazar,SatisAdet()
            };
        }

    }
}
