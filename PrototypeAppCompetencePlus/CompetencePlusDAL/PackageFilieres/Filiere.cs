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
        private string titre;

        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }
        private String description;

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public Filiere()
        {
           
        }
     
    }
}
