using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;

namespace PersonalProjectLabTests
{
    [TestClass]
    public class SimpleBallisticsCalculatorTests
    {
        [TestMethod]
        public void BallisticsCalculator_AverageMuzzleVelocity()
        {
            //arrange
            SimpleBallisticsCalculator trial = new SimpleBallisticsCalculator();

            //act
            decimal avg = trial.CalculateAverageMuzzleVelocity(900, 1000, 1100);

            //assert
            Assert.AreEqual(1000.00m, avg);
        }

        [TestMethod]
        public void BallisticsCalculator_MuzzleAngle()
        {
            //arrange
            SimpleBallisticsCalculator trial = new SimpleBallisticsCalculator();

            //act
            decimal muzzleAngle = trial.CalculateMuzzleAngle(100, 100);

            //assert
            Assert.AreEqual(2.81m, muzzleAngle);
        }
    }
}
