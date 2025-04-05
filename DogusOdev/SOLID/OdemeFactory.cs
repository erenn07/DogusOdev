using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.SOLID
{
    public class OdemeFactory
    {
        public IOdeme yeniNesneOlustur(string className)
        {
            var newObject = System.Reflection.Assembly.GetAssembly(typeof(IOdeme)).CreateInstance("WinFormsApp1.SOLID." + className);

            return (IOdeme)newObject;
        }
    }
}
