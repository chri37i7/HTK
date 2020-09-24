using HTK.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HTK.Tests
{
    /// <summary>
    /// For testing the validation methods in <see cref="Validations"/>
    /// </summary>
    [TestClass]
    public class ValidationTests
    {
        #region ValidateIsDateBefore Tests
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

        /// <summary>
        /// Tests that the implementation of <see cref="Validations.ValidateIsDateBefore(DateTime, DateTime)"/> returns false
        /// </summary>
        [TestMethod]
        public virtual void IsDateBeforeReturnsFalse()
        {
            // Arrange
            DateTime before;
            DateTime after;

            // Act
            before = new DateTime(2030, 12, 24);
            after = new DateTime(2020, 12, 24);
            (bool isValid, string errorMessage) = Validations.ValidateIsDateBefore(before, after);

            // Assert
            Assert.IsTrue(!isValid);
        } 
        #endregion

        #region ValidateIsFloatNegative Tests
        [TestMethod]
        public void IsFloatNegativeReturnsFalse()
        {
            // Arrange:
            int negativeNumber = -1;

            // Act:
            (bool isValid, string errorMessage) = Validations.ValidateIsFloatNegative(negativeNumber);

            // Assert:
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void IsFloatNegativeReturnsTrue()
        {
            // Arrange:
            int positiveNumber = 1;

            // Act:
            (bool isValid, string errorMessage) = Validations.ValidateIsFloatNegative(positiveNumber);

            // Assert:
            Assert.IsTrue(isValid);
        }
        #endregion

        #region ValidateIsStringNull Tests
        [TestMethod]
        public void IsStringNullReturnsFalse()
        {
            // Arrange:
            string emptyString = string.Empty;

            // Act:
            (bool isValid, string errorMessage) = Validations.ValidateIsStringNull(emptyString);

            // Assert:
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void IsStringNullReturnsTrue()
        {
            // Arrange:
            string testString = "This is text";

            // Act:
            (bool isValid, string errorMessage) = Validations.ValidateIsStringNull(testString);

            // Assert:
            Assert.IsTrue(isValid);
        }
        #endregion
    }
}