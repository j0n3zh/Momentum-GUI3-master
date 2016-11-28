using System;
using Momentum_GUI3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanEditMembers()
        {
            
        }

        [TestMethod]
        public void CanAddMember()
        {
           
        }

        [TestMethod]
        public void CanViewMember()
        {
            
        }

        [TestMethod]
        public void CanFindMember()
        {
            
        }

        [TestMethod]
        public void DetectsWrongChars()
        {
            Assert.IsFalse(Checking.input_Check("John", "Smith", "Supervej 4","5260", "Odense", "75458595", "John.Smith@mail.dk", "11-11-1993", "Normal").Contains("Du har angivet et eller flere forbudte karakterer i feltet"));
            Assert.IsTrue(Checking.input_Check("John0", "Smith", "Supervej 4", "5260", "Odense", "75458595", "John.Smith@mail.dk", "11-11-1993", "Normal").Contains("Du har angivet et eller flere forbudte karakterer i feltet"));
            Assert.IsTrue(Checking.input_Check("John", "Smith@", "Supervej 4", "5260", "Odense", "75458595", "John.Smith@mail.dk", "11-11-1993", "Normal").Contains("Du har angivet et eller flere forbudte karakterer i feltet"));
            Assert.IsTrue(Checking.input_Check("John", "Smith", "Supervej 4", "5260", "Odense", "754S8595", "John.Smith@mail.dk", "11-11-1993", "Normal").Contains("Du har angivet et eller flere forbudte karakterer i feltet"));
            Assert.IsTrue(Checking.input_Check("John", "Smith", "Supervej 4", "5260", "Odense^", "754S8595", "John.Smith@mail.dk", "11-11-1993", "Normal").Contains("Du har angivet et eller flere forbudte karakterer i feltet"));
        }

        [TestMethod]
        public void DetectsEmailMistake()
        {
            Assert.IsFalse(Checking.input_Check("John", "Smith", "Supervej 4", "5260", "Odense", "75458595", "John.Smith@mail.dk", "11-11-1993", "Normal").Contains("Du har angivet en forkert e-mail, @ mangler"));
            Assert.IsTrue(Checking.input_Check("John", "Smith", "Supervej 4", "5260", "Odense", "75458595", "John.Smithmail.dk", "11-11-1993", "Normal").Contains("Du har angivet en forkert e-mail, @ mangler"));
        }

        [TestMethod]
        public void DetectsPhoneMistake()
        {
            Assert.IsFalse(Checking.input_Check("John", "Smith", "Supervej 4", "5260", "Odense", "75458595", "John.Smith@mail.dk", "11-11-1993", "Normal").Contains("Du har angivet et telefonnummer som enten er for langt eller for kort"));
            Assert.IsTrue(Checking.input_Check("John", "Smith", "Supervej 4", "5260", "Odense", "7545", "John.Smith@mail.dk", "11-11-1993", "Normal").Contains("Du har angivet et telefonnummer som enten er for langt eller for kort"));
        }

        [TestMethod]
        public void DetectsAdressMistake()
        {
            Assert.IsFalse(Checking.input_Check("John", "Smith", "Supervej 4", "5260", "Odense", "75458595", "John.Smith@mail.dk", "11-11-1993", "Normal").Contains("Addresse skal indeholde et vejnavn og et vejnummer"));
            Assert.IsTrue(Checking.input_Check("John", "Smith", "Supervej", "5260", "Odense", "75458595", "John.Smith@mail.dk", "11-11-1993", "Normal").Contains("Addresse skal indeholde et vejnavn og et vejnummer"));
        }

        [TestMethod]
        public void DetectZipCodeMistake()
        {
            Assert.IsFalse(Checking.input_Check("John", "Smith", "Supervej 4", "5260", "Odense", "75458595", "John.Smith@mail.dk", "11-11-1993", "Normal").Contains("Postnummeret eksisterer ikke"));
            Assert.IsTrue(Checking.input_Check("John", "Smith", "Supervej 4", "11000", "Odense", "75458595", "John.Smith@mail.dk", "11-11-1993", "Normal").Contains("Postnummeret eksisterer ikke"));
        }

    }
}
