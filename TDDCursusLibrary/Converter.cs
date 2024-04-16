using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Converter
    {
        private static readonly decimal AantalCentimeterInEenInch = 2.54m;
        public decimal InchesNaarCentimeters(decimal inches)
        => inches * AantalCentimeterInEenInch;
    }
}
