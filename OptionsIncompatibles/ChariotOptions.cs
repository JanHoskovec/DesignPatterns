using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionsIncompatibles
{
    public class ChariotOptions
    {
        protected IList<OptionVehicule> options = new List<OptionVehicule>();

        public Memento AjouteOption(OptionVehicule option)
        {
            Memento memento = new Memento();
            foreach (var o in options)
                memento.Etat.Add(o);
            foreach (var o in option.OptionsIncompatibles)
                options.Remove(o);
            options.Add(option);
            return memento;
        }

        public void Annuler(Memento memento)
        {
            options = memento.Etat;
        }

        public void AfficheEtat()
        {
            Console.WriteLine("Configuration actuelle : ");
            foreach (var o in options)
                Console.WriteLine(o.Nom);
        }
    }
}
