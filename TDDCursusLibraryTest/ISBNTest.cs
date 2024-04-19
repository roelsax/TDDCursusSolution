using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class ISBNTest
    {
        [DataTestMethod]
        [DataRow(0)] // 0
        [DataRow(-9789027439642L)] // Negatief nummer
        [DataRow(978902743964L)] // 12 cijfers
        [DataRow(97890274396421L)] // 14 cijfers
        [DataRow(9779227439643L)] // Eerste drie cijfers 978 of 979
        [DataRow(8789027439642L)] // 13 cijfers met verkeerd controlegetal 2
        [DataRow(9789027439643L)] // 13 cijfers met verkeerd controlegetal 3
        [DataRow(7789227439640L)] // 13 cijfers met verkeerd controlegetal 0
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void VerkeerdeNummers(long nummer)
        {
            new ISBN(nummer);
        }

        [DataTestMethod]
        [DataRow(9789027439642L)] // 13 Cijfers Met Correct ControleGetal 2
        [DataRow(9789227439640L)] // 13 Cijfers Met Correct ControleGetal 0
        [TestMethod]
        public void CorrecteNummers(long nummer)
        {
            new ISBN(nummer);
        }
        //[TestMethod, ExpectedException(typeof(ArgumentException))]
        //// Het Nummer 0 Is Verkeerd
        //public void New_MetNummer0_IsVerkeerd()
        //{
        //    // Arrange
        //    // Act
        //    // Assert
        //    new ISBN(0);
        //}
        //[TestMethod, ExpectedException(typeof(ArgumentException))]
        //// Een Negatief Nummer Is Verkeerd
        //public void New_MetEenNegatiefNummer_IsVerkeerd()
        //{
        //    // Arrange
        //    // Act
        //    // Assert
        //    new ISBN(-9789027439642L);
        //}
        //[TestMethod, ExpectedException(typeof(ArgumentException))]
        //// Een Nummer Met 12 Cijfers Is Verkeerd
        //public void New_MetEenNummerVan12Cijfers_IsVerkeerd()
        //{
        //    // Arrange
        //    // Act
        //    // Assert
        //    new ISBN(978902743964L);
        //}
        //[TestMethod, ExpectedException(typeof(ArgumentException))]
        //// Een Nummer Met 14 Cijfers Is Verkeerd
        //public void New_MetEenNummerVan14Cijfers_IsVerkeerd()
        //{
        //    // Arrange
        //    // Act
        //    // Assert
        //    new ISBN(97890274396421L);
        //}
        //[TestMethod, ExpectedException(typeof(ArgumentException))]
        //// De Eerste 3 Cijfers Moeten 978 of 979 Zijn
        //public void New_Eerste3Cijfers978Of979_IsVerkeerd()
        //{
        //    // Arrange
        //    // Act
        //    // Assert
        //    new ISBN(9779227439643L);
        //}
        //[TestMethod, ExpectedException(typeof(ArgumentException))]
        //// Een Nummer Met 13 Cijfers Met Verkeerd ControleGetal 2
        //public void New_MetEenNummerVan13CijfersMetVerkeerdControleGetal2_IsVerkeerd()
        //{
        //    // Arrange
        //    // Act
        //    // Assert
        //    new ISBN(8789027439642L);
        //}
        //[TestMethod]
        //// Een Nummer Met 13 Cijfers Met Correct ControleGetal 2
        //public void New_MetEenNummerVan13CijfersMetCorrectControleGetal2_IsCorrect()
        //{
        //    // Arrange
        //    // Act
        //    // Assert
        //    new ISBN(9789027439642L);
        //}
        //[TestMethod, ExpectedException(typeof(ArgumentException))]
        // Een Nummer Met 13 Cijfers Met Verkeerd ControleGetal 3
        //public void New_MetEenNummerVan13CijfersMetVerkeerdControleGetal3_IsVerkeerd()
        //{
        //    // Arrange
        //    // Act
        //    // Assert
        //    new ISBN(9789027439643L);
        //}
        //[TestMethod, ExpectedException(typeof(ArgumentException))]
        //// Een Nummer Met 13 Cijfers Met Verkeerd ControleGetal 0
        //public void New_MetEenNummerVan13CijfersMetVerkeerdControleGetal0_IsVerkeerd()
        //{
        //    // Arrange
        //    // Act
        //    // Assert
        //    new ISBN(7789227439640L);
        //}
        //[TestMethod]
        //// Een Nummer Met 13 Cijfers Met Correct ControleGetal 0
        //public void New_MetEenNummerVan13CijfersMetCorrectControleGetal0_IsCorrect()
        //{
        //    // Arrange
        //    // Act
        //    // Assert
        //    new ISBN(9789227439640L);
        //}
        [TestMethod]
        // ToString moet het nummer teruggeven
        public void ToString_ISBNNummer_MoetHetNummerTeruggeven()
        {
            // Arrange
            var nummer = 9789227439640L;
            var ISBNnummer = new ISBN(nummer);
            // Act
            // Assert
            Assert.AreEqual(nummer.ToString(), ISBNnummer.ToString());
        }
    }
}
