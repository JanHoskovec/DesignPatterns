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

        private LiasseVierge()
        {
            Documents = new List<Document>();
        }

        public static LiasseVierge Instance()
        {
            if (_instance == null)
                _instance = new LiasseVierge();
            return _instance;
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
