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
            var land = landDAO.Read(landcode);
            var oppervlakteAlleLanden = landDAO.FindOppervlakteAlleLanden();
            return (decimal)land.Oppervlakte / oppervlakteAlleLanden;
        }
    }
}
