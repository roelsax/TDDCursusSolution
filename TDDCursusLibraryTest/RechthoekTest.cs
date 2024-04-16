using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class RechthoekTest
    {
        [TestMethod]
        public void Omtrek_IsCorrect()
        {
            Assert.AreEqual(18, new Rechthoek(5, 4).Omtrek());
        }

        [TestMethod]
        public void Oppervlakte_IsCorrect()
        {
            Assert.AreEqual(20, new Rechthoek(5, 4).Oppervlakte());
        }
    }
}
