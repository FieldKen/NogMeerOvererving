using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NogMeerOvererving
{
    class Paard : Dier
    {
        public override int MaxLeeftijd { get { return 30; } }

        public override string MaakGeluid()
        {
            return "Hinnik";
        }
    }
}
