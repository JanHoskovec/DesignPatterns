using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandeTVA
{
    public class Commande
    {
        public Pays Pays { get; set; }

        public decimal CalculeMontantTtc(decimal montantHt)
        {
            return montantHt + this.CalculeTva(montantHt);
        }

        public decimal CalculeTva(decimal montantHt)
        {
            return Pays.CalculeTva(montantHt);
        }
    }
}
