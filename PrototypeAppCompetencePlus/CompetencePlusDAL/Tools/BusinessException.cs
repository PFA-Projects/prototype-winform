using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetencePlus.Tools
{
   public class BusinessException:Exception
    {
        public BusinessException(string exception):base(exception) { 
        
        }
    }
}
