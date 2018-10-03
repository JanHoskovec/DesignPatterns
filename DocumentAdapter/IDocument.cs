using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAdapter
{
    public interface IDocument
    {
        string Contenu { set; }
        void Dessiner();
        void Imprimer();
    }
}
