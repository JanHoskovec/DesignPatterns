using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDocuments
{
    public abstract class Liasse
    {
        private IList<Document> documents = new List<Document>();

        public IList<Document> GetDocuments()
        {
            return documents;
        }

        protected void SetDocuments(IList<Document> docs)
        {
            documents = docs;
        }
    }
}
