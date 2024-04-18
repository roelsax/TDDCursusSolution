using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TDDCursusLibrary;
namespace TDDCursusLibraryTest;
[TestClass]
public class RekeningTest
{
    private Rekening rekening;

    [TestInitialize]
    public void Initialize()
    {
        rekening = new Rekening();
    }
    // Het Saldo Van Een Nieuwe Rekening Is Nul
    [TestMethod]
    public void Saldo_NieuwRekening_IsNul()
    {
        // Arrange
        // Act
        // Assert
        Assert.AreEqual(decimal.Zero, rekening.Saldo);
    }
    // Het Saldo Na Een Eerste Storting Is Het Bedrag Van Die Storting
    [TestMethod]
    public void Saldo_NaEersteStorting_BedragVanDeStorting()
    {
        // Arrange
        var bedrag = 2.5m;
        // Act
        rekening.Storten(bedrag);
        // Assert
        Assert.AreEqual(bedrag, rekening.Saldo);
    }
    // Het Saldo Na Twee Stortingen Is De Som Van De Bedragen Van Die Stortingen
    [TestMethod]
    public void Saldo_NaTweeStortingen_SomVanDeStortingen()
    {
        // Arrange
        // Act
        rekening.Storten(2.5m);
        rekening.Storten(1.2m);
        // Assert
        Assert.AreEqual(3.7m, rekening.Saldo);
    }

    [TestMethod, ExpectedException(typeof(ArgumentException))]
    // Het Bedrag Van Een Storting Mag Niet Nul Zijn
    public void Storten_NulEuroStorten_Exception()
    {
        // Arrange
        // Act
        // Assert
        rekening.Storten(decimal.Zero);
    }
    [TestMethod, ExpectedException(typeof(ArgumentException))]
    // Het Bedrag Van Een Storting Mag Niet Negatief Zijn
    public void Storten_NegatiefBedragStorten_Exception()
    {
        // Arrange
        // Act
        // Assert
        rekening.Storten(-1m);
    }
    [TestMethod]
    public void Stortingen_Stort5en10_Get5en10List()
    {
        rekening.Storten(5m);
        rekening.Storten(10m);

        Assert.AreEqual(2, rekening.Stortingen().Count());
        Assert.IsTrue(rekening.Stortingen().Contains(5m));
        Assert.IsTrue(rekening.Stortingen().Contains(10m));
    }

    [TestMethod]
    public void Stortingen_BijGeenStorting_0Stortingen()
    {
        Assert.AreEqual(0, rekening.Stortingen().Count());
    }

    [TestMethod]
    public void Stortingen_EenStorting_StortingenVan13()
    {
        rekening.Storten(13m);

        Assert.AreEqual(1,rekening.Stortingen().Count());
        Assert.IsTrue(rekening.Stortingen().Contains(13m));
    }

    [TestMethod]
    public void StortingenGesorteerd_DrieStortingen_JuisteVolgOrde()
    {
        rekening.Storten(15m);
        rekening.Storten(10m);
        rekening.Storten(5m);

        Assert.AreEqual(3, rekening.StortingenGesorteerd().Count());
        Assert.AreEqual(0, rekening.StortingenGesorteerd().IndexOf(5m));
        Assert.AreEqual(1, rekening.StortingenGesorteerd().IndexOf(10m));
        Assert.AreEqual(2, rekening.StortingenGesorteerd().IndexOf(15m));
    }
}
