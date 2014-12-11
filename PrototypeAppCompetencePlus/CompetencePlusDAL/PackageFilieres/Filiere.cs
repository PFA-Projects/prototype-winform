using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetencePlus.PackageFilieres
{
    public class Filiere
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public Filiere()
        {
           
        }
    }
}
