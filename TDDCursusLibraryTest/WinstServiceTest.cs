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
    public class WinstServiceTest
    {
        private WinstService winstService = null!;
        private IKostRepository KostRepository = null!;
        private IOpbrengstRepository OpbrengstRepository = null!;
        private Mock<IKostRepository> IKostMockFactory = null!;
        private Mock<IOpbrengstRepository> IOpbrengstMockFactory = null!;

        [TestInitialize]
        public void Initialize()
        {
            //KostRepository = new KostRepositoryStub();
            //OpbrengstRepository = new OpbrengstRepositoryStub();
            IKostMockFactory = new Mock<IKostRepository>();
            KostRepository = IKostMockFactory.Object;
            IOpbrengstMockFactory = new Mock<IOpbrengstRepository>();
            OpbrengstRepository = IOpbrengstMockFactory.Object;

            IKostMockFactory.Setup(IKostRep => IKostRep.FindTotaleKost()).Returns(300);

            IOpbrengstMockFactory.Setup(IOpbrengstRep => IOpbrengstRep.FindTotaleOpbrengst()).Returns(500);

            winstService = new WinstService(KostRepository, OpbrengstRepository);
        }

        [TestMethod]
        public void GetWinstTest()
        {
            Assert.AreEqual(200, winstService.GetWinst());
        }
    }
}
