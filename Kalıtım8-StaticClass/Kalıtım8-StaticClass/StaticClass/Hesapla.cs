using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım8_StaticClass.StaticClass
{
    class Hesapla
    {
        /// <summary>
        /// IslemYap adında 2 adet int parametre alan static bir metod olusturduk
        /// Static oldugu için nesne oluşturmadan çağırabileceğiz.
        /// </summary>
        /// <param name="sayi1"></param>
        /// <param name="sayi2"></param>
        /// <returns></returns>
        public static int İslemYap(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
