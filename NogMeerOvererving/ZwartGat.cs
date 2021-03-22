using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NogMeerOvererving
{
    class ZwartGat : Exception
    {
        public override string ToString()
        {
            string extraInfo = "Ge hebt het grat na de kloten gedaan.";
            return extraInfo;// + "\n" + base.ToString();
        }
    }
}
