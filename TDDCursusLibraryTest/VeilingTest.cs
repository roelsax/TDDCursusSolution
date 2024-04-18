using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class VeilingTest
    {
        private Veiling veiling;

        [TestInitialize]
        public void Initialize()
        {
            veiling = new Veiling();
        }

        [TestMethod]
        public void DoeBod_HoogsteBodIsNul()
        {

            Assert.AreEqual(0, veiling.HoogsteBod);
        }

        [TestMethod]
        public void DoeBod_Verhoging_1000()
        {
            veiling.DoeBod(1000);

            Assert.AreEqual(1000, veiling.HoogsteBod);
        }

        [TestMethod]
        public void DoeBod_DubbelBod_HoogsteBodIs3000()
        {
            veiling.DoeBod(1000);
            veiling.DoeBod(3000);
            veiling.DoeBod(2500);

            Assert.AreEqual(3000, veiling.HoogsteBod);
        }
    }
}
