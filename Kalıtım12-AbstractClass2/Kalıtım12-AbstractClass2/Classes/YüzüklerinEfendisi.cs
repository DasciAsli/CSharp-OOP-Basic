using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım12_AbstractClass2.Classes
{
    class YüzüklerinEfendisi : Kitap
    {
        public override string KitapAd { get; set; }
        public override string KitapYazar { get; set; }

        public override int SatisAdet()
        {
            return 150;
        }
       
    }
}
