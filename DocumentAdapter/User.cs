using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAdapter
{
    /// <summary>
    /// This class is for accessors exercise only
    /// </summary>
    public class User
    {
        private string _nom;
        private string _prenom;
        private int _age;

        // With lambdas
        public string Nom { get => _nom; set => _nom = value; }
        // Without lambdas
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        public int Age { get => _age; set => _age = value; }
    }
}
