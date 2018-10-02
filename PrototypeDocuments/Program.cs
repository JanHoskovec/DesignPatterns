using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDocuments
{
    class Program
    {
        static void Main(string[] args)
        {
            LiasseClient maLiasse = new LiasseClient();
            maLiasse.Creer("John Doe");
            maLiasse.Afficher();
            LiasseClient maDeuxiemeLiasse = new LiasseClient();
            maDeuxiemeLiasse.Creer("Jane Doe");
            maDeuxiemeLiasse.Afficher();
            Console.ReadLine();
        }

    }
}
