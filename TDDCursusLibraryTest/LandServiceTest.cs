using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;
using Moq;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class LandServiceTest
    {
        private ILandDAO landDAO = null!; // Stub
        private LandService landService = null!; // Te testen class
        private Mock<ILandDAO> mockFactory = null!;
        [TestInitialize]
        public void Initialize()
        {
            //landDAO = new LandDAOStub();
            mockFactory = new Mock<ILandDAO>();
            landDAO = mockFactory.Object;

            mockFactory.Setup(eenLandDAO =>
                eenLandDAO.FindOppervlakteAlleLanden()).Returns(20);

            mockFactory.Setup(eenLandDAO => eenLandDAO.Read("B")).Returns(new Land
            {
                Landcode = "B",
                Oppervlakte = 5
            });

            mockFactory.Setup(eenLandDAO => eenLandDAO.Read("NL")).
                Returns(new Land { Landcode = "NL", Oppervlakte = 6 });

            mockFactory.Setup(eenLandDAO => eenLandDAO.Read(string.Empty)).
            Throws(new ArgumentException());


            landService = new LandService(landDAO);

        }
        [TestMethod]
        public void FindVerhoudingOppervlakteLandTovOppervlakteAlleLanden()
        {
            Assert.AreEqual(0.25m,
            landService.FindVerhoudingOppervlakteLandTovOppervlakteAlleLanden("B"));

            mockFactory.Verify(eenLandDAO => eenLandDAO.FindOppervlakteAlleLanden());
            mockFactory.Verify(eenLandDAO => eenLandDAO.Read("B"));
        }
    }
}
