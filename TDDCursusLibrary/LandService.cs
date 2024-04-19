using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class LandService
    {
        //private LandDAO landDAO = new LandDAO();
        private readonly ILandDAO landDAO = null!;
        // Constructor
        public LandService(ILandDAO landDAO)
        => this.landDAO = landDAO;
        public decimal FindVerhoudingOppervlakteLandTovOppervlakteAlleLanden(string landcode)
        {
            throw new NotImplementedException();
        }
    }
}
