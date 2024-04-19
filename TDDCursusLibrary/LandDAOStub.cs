using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class LandDAOStub : ILandDAO
    {
        public Land Read(string landcode)
        => new Land { Landcode = landcode, Oppervlakte = 5 };
        public int FindOppervlakteAlleLanden()
        => 20;
    }
}
