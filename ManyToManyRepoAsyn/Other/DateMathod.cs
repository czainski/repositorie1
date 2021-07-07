using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelationshipManyToManyCore3.Other
{
    public static class DateMathod
  {
        public static (DateTime Od, DateTime Do) TestDate(DateTime Od, DateTime Do)
        {
            if (Do.Year == 1 && Od.Year > 1900)
                Do = DateTime.Now;
            else if (Do.Year > 1900 && Od.Year == 1)
                Od = new DateTime(1900, 1, 1, 1, 0, 0);
            else if (Do.Year == 1 && Od.Year == 1)
            {
                Od = new DateTime(1900, 1, 1, 1, 0, 0);
                Do = DateTime.Now;
            }
            return ( Od,  Do);
        }
    }
}
