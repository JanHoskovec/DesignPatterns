using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionsIncompatibles
{
    public class OptionVehicule
    {
        public string Nom { get; set; }
        public List<OptionVehicule> OptionsIncompatibles { get; set; } = new List<OptionVehicule>();
    }
}
