using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionsIncompatibles
{
    public class Memento
    {
        public IList<OptionVehicule> Etat { get; protected set; } = new List<OptionVehicule>();
    }
}
