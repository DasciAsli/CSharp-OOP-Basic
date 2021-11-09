using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım13_Interface.Classes
{
    interface IProducts
    {
        int ProductId { get; set; }
        string ProductName { get; set; }
        float Price { get; set; }
    }
}
