using NUnit.Framework;
using System;

namespace Rf.Domain.Tests
{
    [TestFixture]
    public class FormulierTests
    {
        [Test]
        public void Formulier_can_afsluiten()
        {
            // Arrange
            var formulier = new Formulier();
            
            // Act
            formulier.Afsluiten();

            // Assert
            Assert.AreEqual(EnumStatusRf.Afgesloten, formulier.StatusRfEnum);
            Assert.AreEqual(DateTime.Now.Date, formulier.AfwerkingsDatum);
        }
    }
}
