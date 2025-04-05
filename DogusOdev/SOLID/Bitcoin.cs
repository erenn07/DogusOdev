using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.SOLID
{
    public class Bitcoin : IOdeme
    {
        public string Odeme(double price)
        {
            return $"Bitcoin ile {price} TL ödendi.";
        }
    }
}
