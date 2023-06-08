using DeathDynamicCalculatorProject;

namespace Tests
{
    [TestClass]
    public class DynamicCalculatorTests
    {
        private DynamicCalculator _calculator = new(new Dictionary<int, float> { { 2000, 200.5f }, { 2001, 2012.10f } });

        [TestMethod]
        public void IsAbsoluteMoreThanZero()
        {
            Assert.IsTrue(_calculator.Absolute(2, 1) > 0);
        }

        [TestMethod]
        public void IsRelativeMoreThanZero()
        {
            Assert.IsTrue(_calculator.Relative(2, 1) > 0);
        }

        [TestMethod]
        public void IsAverageMoreThanZero()
        {
            Assert.IsTrue(_calculator.Average() > 0);
        }
    }
}