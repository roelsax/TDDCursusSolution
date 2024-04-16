using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class ArtikelTest
    {
        [TestMethod]
        public void PrijsInclusiefBtw_121_100euro21percent()
        {
            Assert.AreEqual(121, new Artikel(100m, 0.21m).PrijsInclusiefBtw());
        }
    }
}
