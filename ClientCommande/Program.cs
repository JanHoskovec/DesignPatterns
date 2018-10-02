using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientCommande
{
    class Program
    {
        static void Main(string[] args)
        {
            Client clientComptant = new ClientComptant();
            clientComptant.nouvelleCommande(1000D);
            Client clientCredit = new ClientCredit();
            clientCredit.nouvelleCommande(1200D);
            Console.ReadLine();
        }
    }
}
