using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım3_Encapsulation
{
    class İslemYap
    {
        string durumRaporu;

        //Full property ile kapsülleme yapıyoruz yani dışarıdan gönderilen veriyi gözden geçirip ona göre sonuc döndürüyoruz.
        public string DurumRaporu 
        {
            get
            {
                return durumRaporu;
            } 
            set
            {
                int sonuc = Convert.ToInt32(value);
                if (sonuc >= 0 && sonuc < 50)
                {
                    durumRaporu = "Kaldınız : FF";
                }
                else if (sonuc > 50)
                {
                    durumRaporu = "Geçtiniz : AA";
                }
            }
        }
    }
}
