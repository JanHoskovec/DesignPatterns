using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueVehicules
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();
            
            // D'abord, on va construire des véhicules à essence
            catalogue.MaFabrique = new FabriqueVehiculeEssence();
            catalogue.MesAutomobiles.Add(catalogue.MaFabrique.CreerAutomobile());
            catalogue.MesScooters.Add(catalogue.MaFabrique.CreerScooter());

            // Maintenant, on passe à la fabrication des véhicules électriques
            catalogue.MaFabrique = new FabriqueVehiculeElectricite();
            catalogue.MesAutomobiles.Add(catalogue.MaFabrique.CreerAutomobile());
            catalogue.MesScooters.Add(catalogue.MaFabrique.CreerScooter());

            // Affichons ce qu'on a
            Console.WriteLine("Mes scooters fabriqués :");
            foreach (var scooter in catalogue.MesScooters)
            {
                Console.WriteLine(scooter);
            }
            Console.WriteLine("Mes automobiles fabriqués :");
            foreach (var auto in catalogue.MesAutomobiles)
            {
                Console.WriteLine(auto);
            }
            Console.ReadLine();
        }
    }
}
