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
            catalogue.MesAutomobiles.Add(catalogue.MaFabrique.CreerAutomobile("Twingo", "vert", 15, 4D));
            catalogue.MesScooters.Add(catalogue.MaFabrique.CreerScooter("Vespa", "gris", 5));

            // Maintenant, on passe à la fabrication des véhicules électriques
            catalogue.MaFabrique = new FabriqueVehiculeElectricite();
            catalogue.MesAutomobiles.Add(catalogue.MaFabrique.CreerAutomobile("e tron", "noir", 80, 5D));
            catalogue.MesScooters.Add(catalogue.MaFabrique.CreerScooter("C Evolution", "blanc", 15));

            // Affichons ce qu'on a
            Console.WriteLine("Mes scooters fabriqués :");
            foreach (var scooter in catalogue.MesScooters)
            {
                scooter.AfficheCaracteristiques();
            }
            Console.WriteLine("Mes automobiles fabriqués :");
            foreach (var auto in catalogue.MesAutomobiles)
            {
                auto.AfficheCaracteristiques();
            }
            Console.ReadLine();
        }
    }
}
