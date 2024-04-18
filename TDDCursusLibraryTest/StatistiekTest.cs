using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class StatistiekTest
    {

        [TestMethod]
        public void Gemiddelde_Van15en10en5_Is10()
        {
            Assert.AreEqual(10, Statistiek.Gemiddelde(new decimal[] { 5m, 10m ,15m}));
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Gemiddelde_VanNull_ThrowsException()
        {
            Statistiek.Gemiddelde(null);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Gemiddelde_VanLegeArray_ThrowsException()
        {
            Statistiek.Gemiddelde(new decimal[] { });
        }

        [TestMethod]
        public void Gemiddelde_VanGetal_IsGetal()
        {
            Assert.AreEqual(1.45m, Statistiek.Gemiddelde(new decimal[] { 1.45m }));
        }
    }
}
