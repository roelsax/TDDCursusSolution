using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Rekeningnummer
    {
        private static readonly Regex regex = new Regex("^BE(\\d{2})(\\d{12})$");
        private readonly string rekeningnummer;
        public Rekeningnummer(string rekeningnummer)
        {
            //throw new NotImplementedException();

            if (!regex.IsMatch(rekeningnummer))
                throw new ArgumentException("Verkeerd formaat");
            var controleString = rekeningnummer.Substring(2, 2);
            var rekeningGetal = long.Parse(rekeningnummer.Substring(4, rekeningnummer.Length - 4) + "1114" + controleString);
            var controleGetal = int.Parse(controleString);
            if (controleGetal < 2 || controleGetal > 98)
                throw new ArgumentException("1° of 2° cijfer verkeerd");
            if (rekeningGetal % 97 != 1)
                throw new ArgumentException("Nummer bevat verkeerde cijfers");
            this.rekeningnummer = rekeningnummer;
        }
        public override string ToString()
        {
            //throw new NotImplementedException();

            return rekeningnummer;
        }
    }
}
