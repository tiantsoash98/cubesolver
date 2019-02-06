using Microsoft.VisualStudio.TestTools.UnitTesting;
using CubeSolver.Domain.Enums;
using CubeSolver.Domain.Extensions;

namespace UnitTests.Infrastructure
{
    [TestClass]
    public class FacePositionTest
    {
        [TestMethod]
        public void RotateClockwise()
        {
            var result = FacePosition.Front.RotateClockwise(PickType.Vertical);
            Assert.AreEqual(FacePosition.Up, result);
        }

        [TestMethod]
        public void RotateAnticlockwise()
        {
            var result = FacePosition.Up.RotateAnticlockwise(PickType.Vertical);
            Assert.AreEqual(FacePosition.Front, result);
        }
    }
}
