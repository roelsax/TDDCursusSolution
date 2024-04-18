using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public static class Statistiek
    {
        public static decimal Gemiddelde(decimal[] getallen) 
        {
            if (getallen == null || getallen.Count() == 0) {
                throw new ArgumentException("Gelieve een reeks getallen door te geven.");
            }
            //throw new NotImplementedException();
            return getallen.Average();
        }
    }
}
