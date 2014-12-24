using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.Tools;


namespace CompetencePlus.PackageFilieres
{
    public class FiliereBAO : FiliereDAO
    {
        public new void Add(Filiere f) {
            if (f.Titre.Length<4)
            {
                throw new BusinessException("Le titre est trop court");
            }
            else
            {
                    new FiliereDAO().Add(f);
            }
        
        }

    }
}
