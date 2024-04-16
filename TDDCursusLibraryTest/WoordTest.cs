using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class WoordTest
    {
        [TestMethod]
        public void IsPalindroom_Lepel_IsPalindroom()
        {
            Assert.IsTrue(new Woord("lepel").IsPalindroom());
        }

        [TestMethod]
        public void IsPalindroom_Soms_IsGeenPalindroom()
        {
            Assert.IsFalse(new Woord("soms").IsPalindroom());
        }

        [TestMethod]
        public void IsPalindroom_EmptyString_IsPalindroom()
        {
            Assert.IsTrue(new Woord("").IsPalindroom());
        }
    }
}
