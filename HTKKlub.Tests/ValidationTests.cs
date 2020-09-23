using HTKKlub.Utilities;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HTKKlub.Tests
{
    /// <summary>
    /// For testing the validation methods in <see cref="Validations"/>
    /// </summary>
    [TestClass]
    public class ValidationTests
    {
        /// <summary>
        /// Tests that the implementation of <see cref="Validations.ValidateIsDateBefore(DateTime, DateTime)"/> returns true
        /// </summary>
        [TestMethod]
        public virtual void IsDateBeforeReturnsTrue()
        {
            // Arrange
            DateTime before;
            DateTime after;

            // Act
            before = new DateTime(2019, 12, 24);
            after = DateTime.Now;
            (bool isValid, string errorMessage) = Validations.ValidateIsDateBefore(before, after);

            // Assert
            Assert.IsTrue(isValid);
        }
    }
}
