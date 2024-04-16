using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Woord
    {
        public string woord { get; set; }

        public Woord(string woord)
        {
            this.woord = woord;
        }

        public bool IsPalindroom()
        {
    
            char[] chars = woord.ToCharArray();
            Array.Reverse(chars);
            return woord == new String(chars) ? true : false;
        }
    }
}
