using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace CompetencePlus.PackageStagiaires
{
    public class StagiaireBAO : StagiaireDAO
    {

        public static new void Add(Stagiaire s)
        {
            if (s.Nom != "")
                new StagiaireDAO().Add(s);

        }
         
    }
}
