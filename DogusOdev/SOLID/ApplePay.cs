using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.SOLID
{
    public class ApplePay : IOdeme
    {
        public string Odeme(double price)
        {
            return $"Apple Pay ile {price} TL ödendi.";
        }
    }
}
