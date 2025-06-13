using Microsoft.VisualStudio.TestTools.UnitTesting;
using modul12_2211104070;

namespace modul12_2211104070_Tests
{
    [TestClass]
    public class CariNilaiPangkatTests
    {
        private Form1 form;

        [TestInitialize]
        public void Setup()
        {
            form = new Form1();
        }

        [TestMethod]
        public void CariNilaiPangkat_BEqualsZero_ReturnsOne()
        {
            // Arrange
            int a = 5;
            int b = 0;

            // Act
            long result = form.CariNilaiPangkat(a, b);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CariNilaiPangkat_AEqualsZero_BEqualsZero_ReturnsOne()
        {
            // Arrange
            int a = 0;
            int b = 0;

            // Act
            long result = form.CariNilaiPangkat(a, b);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CariNilaiPangkat_BNegative_ReturnsMinusOne()
        {
            // Arrange
            int a = 2;
            int b = -3;

            // Act
            long result = form.CariNilaiPangkat(a, b);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CariNilaiPangkat_AGreaterThan100_ReturnsMinusTwo()
        {
            // Arrange
            int a = 150;
            int b = 2;

            // Act
            long result = form.CariNilaiPangkat(a, b);

            // Assert
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void CariNilaiPangkat_BGreaterThan10_ReturnsMinusTwo()
        {
            // Arrange
            int a = 2;
            int b = 15;

            // Act
            long result = form.CariNilaiPangkat(a, b);

            // Assert
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void CariNilaiPangkat_ValidInput_ReturnsCorrectResult()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            long result = form.CariNilaiPangkat(a, b);

            // Assert
            Assert.AreEqual(8, result); // 2^3 = 8
        }

        [TestMethod]
        public void CariNilaiPangkat_ValidInput2_ReturnsCorrectResult()
        {
            // Arrange
            int a = 3;
            int b = 4;

            // Act
            long result = form.CariNilaiPangkat(a, b);

            // Assert
            Assert.AreEqual(81, result); // 3^4 = 81
        }

        [TestMethod]
        public void CariNilaiPangkat_OverflowCondition_ReturnsMinusThree()
        {
            // Arrange
            int a = 100;
            int b = 10;

            // Act
            long result = form.CariNilaiPangkat(a, b);

            // Assert
            Assert.AreEqual(-3, result); // Should overflow
        }

        [TestMethod]
        public void CariNilaiPangkat_EdgeCase_A1_ReturnsOne()
        {
            // Arrange
            int a = 1;
            int b = 100; // This will exceed b > 10 rule

            // Act
            long result = form.CariNilaiPangkat(a, b);

            // Assert
            Assert.AreEqual(-2, result); // Should return -2 due to b > 10
        }

        [TestMethod]
        public void CariNilaiPangkat_EdgeCase_A1_B10_ReturnsOne()
        {
            // Arrange
            int a = 1;
            int b = 10;

            // Act
            long result = form.CariNilaiPangkat(a, b);

            // Assert
            Assert.AreEqual(1, result); // 1^10 = 1
        }

        [TestCleanup]
        public void Cleanup()
        {
            form?.Dispose();
        }
    }
}