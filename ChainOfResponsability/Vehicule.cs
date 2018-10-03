using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class Vehicule : ObjetBase
    {
        protected string laDescription;

        public Vehicule(string description) { this.laDescription = description; }

        protected override string description { get => laDescription; }
    }
}
