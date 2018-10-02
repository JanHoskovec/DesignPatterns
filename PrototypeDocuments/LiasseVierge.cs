using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDocuments
{
    public class LiasseVierge : Liasse
    {
        private static LiasseVierge _instance = null;

        public static LiasseVierge Instance()
        {
            if (_instance == null)
                return new LiasseVierge();
            return _instance;
        }
        
        private LiasseVierge()
        {
            Documents = new List<Document>();
        }
        public void Ajouter(Document d)
        {
            Documents.Add(d);
        }

        public void Retirer(Document d)
        {
            Documents.Remove(d);
        }
        
    }
}
