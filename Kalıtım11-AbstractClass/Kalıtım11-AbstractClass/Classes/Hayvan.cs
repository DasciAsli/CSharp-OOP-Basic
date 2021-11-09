using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım11_AbstractClass.Classes
{
    /// <summary>
    /// abstract bir Hayvan classı olusturduk ve abstract memberlar olusturduk içinde 
    /// Bu memberları Hayvandan kalıtım alan tüm derived sınıflar kullanmak ZORUNDADIR.
    /// ve içlerinin abstract classda doldurmuyorum çünkü kalıtım alan derived classlarda blokların içi doldurulacaktır.
    /// 
    /// </summary>
    abstract class Hayvan
    {
        public abstract string Ad { get; set; }
        public abstract string Cins { get; set; }
        public abstract string Cinsiyet { get; set; }
        public abstract DateTime DogumTarihi { get; set; }
        public abstract string Dogum();
        public abstract string Beslenme();
        public abstract string Olum();

    }
}
