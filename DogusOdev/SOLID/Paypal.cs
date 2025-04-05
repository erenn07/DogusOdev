using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.SOLID
{
    public class Paypal : IOdeme
    {
        public string Odeme(double price)
        {
            return $"Paypal ile {price} TL ödendi.";
        }
    }
}
