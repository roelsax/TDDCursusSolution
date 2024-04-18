using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class ISBN
    {
        private long isbn;
        public ISBN(long nummer) {
            if (nummer.ToString().Length != 13)
            {
                throw new ArgumentException("De ISBN mag alleen 13 tekens lang zijn.");
            }

            int eersteDrieCijfers = Convert.ToInt16(nummer.ToString().Substring(0, 3));
            
            if (eersteDrieCijfers != 978 && eersteDrieCijfers != 979)
            {
                throw new ArgumentException("Een ISBN mag alleen met 978 of 979 beginnen");
            }

            List<int> onevenCijfers = new List<int>();
            List<int> evenCijfers = new List<int>();
            

            for (int i = 0; i < 12; i++)
            {
                char nummerString = nummer.ToString()[i];
                int digit = Int32.Parse(nummerString.ToString());

                if ((i + 1) % 2 == 0) 
                {
                    evenCijfers.Add(digit);
                } else
                {
                    onevenCijfers.Add(digit);
                }
            }

            int tussenTotaal = onevenCijfers.Sum() + (evenCijfers.Sum() * 3);
            int naastGelegenHoger10Tal = tussenTotaal - tussenTotaal % 10 + 10;
            int verschil = naastGelegenHoger10Tal - tussenTotaal;
            string laatsteCijfer = nummer.ToString().Substring(12, 1);
            
            if (verschil == 10)
            {
                if (Int32.Parse(laatsteCijfer) !=  0)
                {
                    throw new ArgumentException("Verkeerd controlegetal.");
                }
            }else
            { 
                if (Int32.Parse(laatsteCijfer) != verschil)
                {
                    throw new ArgumentException("Verkeerd controlegetal.");
                }
            }

            this.isbn = nummer;
            //throw new NotImplementedException();
        }

        public override string ToString()
        {
            //throw new NotImplementedException();
            return isbn.ToString();

        }
    }
}
