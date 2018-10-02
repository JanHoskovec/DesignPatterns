using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiasseVehicule
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez choisir le type du document");
            int[] values = (int[])Enum.GetValues(typeof(TypeFormat));
            foreach (var value in values)
            {
                Console.Write($"{value} : {(TypeFormat)value} ");
            }
            Console.Write("\n");
            int i = -1;
            bool valid = false;
            ClientVehicule client = null;
            while (!valid)
            {
                valid = int.TryParse(Console.ReadLine(), out i);
                client = new ClientVehicule((TypeFormat)i);
                valid = client.vendeur != null; //There should be a more elegant way
                if(!valid)
                    Console.WriteLine("Saisie invalide. Veuillez réessayer.");
            }

            
            Console.WriteLine("Veuillez saisir le nom du client");
            string nom = Console.ReadLine();

            client.vendeur.construit(nom).imprime();

            Console.ReadLine();

        }
    }
}
