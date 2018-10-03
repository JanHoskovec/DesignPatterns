using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionsIncompatibles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize options
            OptionVehicule siegesCuir = new OptionVehicule() { Nom = "Sièges en cuir" };
            OptionVehicule siegesSportifs = new OptionVehicule() { Nom = "Sièges sportif" };
            siegesCuir.OptionsIncompatibles.Add(siegesSportifs);
            siegesSportifs.OptionsIncompatibles.Add(siegesCuir);

            // Pick one
            ChariotOptions myChariot = new ChariotOptions();
            List<Memento> historique = new List<Memento>();
            historique.Add(myChariot.AjouteOption(siegesCuir));
            myChariot.AfficheEtat();

            // Pick the other
            historique.Add(myChariot.AjouteOption(siegesSportifs));
            myChariot.AfficheEtat();

            // Return to previous state
            myChariot.Annuler(historique.Last());
            myChariot.AfficheEtat();

            Console.ReadLine();
        }
    }
}
