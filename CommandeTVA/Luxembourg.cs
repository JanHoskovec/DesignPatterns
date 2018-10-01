using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandeTVA
{
    public class Luxembourg : Pays
    {
        public override decimal CalculeTva(decimal montantHt)
        {
            return montantHt * 0.15M;
        }
    }
}
