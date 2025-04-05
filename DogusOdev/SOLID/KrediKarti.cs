using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.SOLID
{
    public class KrediKarti : IOdeme
    {
        public string Odeme(double price)
        {
            return $"Kredi kartı ile {price} TL ödendi.";
        }
    }
}
