using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDocuments
{
    public abstract class Liasse
    {
        public IList<Document> Documents { get; protected set; }
        
    }
}
