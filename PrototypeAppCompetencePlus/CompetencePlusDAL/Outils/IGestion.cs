using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetencePlus.Outils
{
    public interface IGestion<Obj>
    {
        void Add(Obj o);
        void Update(Obj o);
         void Delete(int id);
         List<Obj> Select();

        /// <summary>
        ///  Rechercher par Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
         Obj FindById(int id);
    }
}
