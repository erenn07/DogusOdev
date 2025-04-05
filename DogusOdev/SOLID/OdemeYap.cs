using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.SOLID
{
    public class OdemeYap
    {
        public IOdeme iOdeme;

        public OdemeYap(IOdeme iOdeme)
        {
            this.iOdeme = iOdeme;
        }

        public string OdemeIslemiYap(double price)
        {
            return iOdeme.Odeme(price);
        }
    }
}
