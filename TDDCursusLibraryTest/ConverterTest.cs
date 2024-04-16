﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class ConverterTest
    {
        [TestMethod]
        public void InchesNaarCentimeters_1Inch_Is2punt54Centimeters()
        {
            // Arrange
            // Act
            // Assert
            Assert.IsTrue(new Converter().InchesNaarCentimeters(1m).Equals(2.54m));
        }
    }
}
