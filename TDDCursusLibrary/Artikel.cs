using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Artikel
    {
        public decimal prijsExclusiefBtw {  get; set; }
        public decimal btwPercentage {  get; set; }

        public Artikel(decimal prijsExclusiefBtw, decimal btwPercentage)
        {
            this.prijsExclusiefBtw = prijsExclusiefBtw;
            this.btwPercentage = btwPercentage;
        }

        public decimal PrijsInclusiefBtw()
        {
            return prijsExclusiefBtw + (prijsExclusiefBtw * btwPercentage);
        }
    }
}
