using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    public class RekeningnummerTest
    {
        [TestMethod]
        // Nummer met 16 tekens en Correct Controle Is OK
        public void New_MetCorrectNummerBE72091012240116_IsOK()
        {
            // Arrange
            // Act
            // Assert
            new Rekeningnummer("BE72091012240116");
        }
        [TestMethod]
        // Nummer met 16 tekens en Correct Controle Is OK
        public void New_MetCorrectNummerBE68539007547034_IsOK()
        {
            // Arrange
            // Act
            // Assert
            new Rekeningnummer("BE68539007547034");
        }
        [TestMethod]
        // Nummer met 16 tekens en Correct Controle Is OK
        public void New_MetCorrectNummerBE02063588295840_IsOK()
        {
            // Arrange
            // Act
            // Assert
            new Rekeningnummer("BE02063588295840"); // controlegetal < 10
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        // Nummer met 17 tekens Is niet OK
        public void New_MetTeLangNummer_IsNietOK()
        {
            // Arrange
            // Act
            // Assert
            new Rekeningnummer("BE720910122401160");
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        // Nummer met 15 tekens Is niet OK
        public void New_MetTeKortNummer_IsNietOK()
        {
            // Arrange
            // Act
            // Assert
            new Rekeningnummer("BE7209101224011");
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        // Niet-Belgisch Nummer Is niet OK
        public void New_NietBelgischNummer_IsNietOK()
        {
            // Arrange
            // Act
            // Assert
            new Rekeningnummer("NL72091012240116"); // NL
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        // Nummer met ongeldige tekens Is niet OK
        public void New_NummerMetOngeldigeTekens_IsNietOK()
        {
            // Arrange
            // Act
            // Assert
            new Rekeningnummer("BEX209101224011Y");
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        // Nummer met te klein controlegetal Is niet OK
        public void New_NummerMetTeKleinControlegetal_IsNietOK()
        {
            // Arrange
            // Act
            // Assert
            new Rekeningnummer("BE01091012240116"); // 01
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        // Nummer met te groot controlegetal Is niet OK
        public void New_NummerMetTeGrootControlegetal_IsNietOK()
        {
            // Arrange
            // Act
            // Assert
            new Rekeningnummer("BE99091012240116"); // 99
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        // Nummer met verkeerde controleberekening Is niet OK
        public void New_NummerMetVerkeerdeControleberekening_IsNietOK()
        {
            // Arrange
            // Act
            // Assert
            new Rekeningnummer("BE72091012240115"); // 72
        }
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        // Nummer met NULL Is niet OK
        public void New_NummerMetNULL_IsNietOK()
        {
            // Arrange
            // Act
            // Assert
            new Rekeningnummer(null
            !);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        // Leeg Nummer Is niet OK
        public void New_LeegNummer_IsNietOK()
        {
            // Arrange
            // Act
            // Assert
            new Rekeningnummer(String.Empty);
        }
        [TestMethod]
        // ToString Moet Het Nummer Teruggeven
        public void ToString_RekeningNummer_MoetHetNummerTeruggeven()
        {
            // Arrange
            var nummer
            = "BE72091012240116"
            ;
            var rekeningnummer
            = new Rekeningnummer(nummer);
            // Act
            // Assert
            Assert.AreEqual(nummer, rekeningnummer.ToString());
        }
    }
}
