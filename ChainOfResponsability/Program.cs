using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjetBase myVehicule1 = new Vehicule("MonAuto");
            Console.WriteLine(myVehicule1.donneDescription());

            ObjetBase myModele1 = new Modele("Mondeo", "Comme en avait je ne sais plus qui");
            ObjetBase myVehicule2 = new Vehicule(null);
            myVehicule2.Suivant = myModele1;
            Console.WriteLine(myVehicule2.donneDescription());

            ObjetBase myVehicule3 = new Vehicule(null);
            ObjetBase myModele2 = new Modele(null, null);
            ObjetBase myMarque1 = new Marque("Ford", "depuis longtemps", "your Fordship");
            myVehicule3.Suivant = myModele2;
            myModele2.Suivant = myMarque1;
            Console.WriteLine(myVehicule3.donneDescription());

            Console.ReadLine();
        }
    }
}
