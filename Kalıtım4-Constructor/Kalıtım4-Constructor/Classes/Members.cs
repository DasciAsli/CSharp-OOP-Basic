using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım4_Constructor.Classes
{
    class Members
    {
        
        string[] dizi = new string[3];
        public Members(string[] x)
        {
            dizi = x;
            x[0] = "Ayşe";
            x[1] = "Mehmet";
            x[2] = "Ali";
        }
    }
}
