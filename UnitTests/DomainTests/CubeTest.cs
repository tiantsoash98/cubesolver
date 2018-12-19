using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CubeSolver.Domain;
using CubeSolver.Infrastructure.Enums;
using CubeSolver.Infrastructure.Extensions;

namespace UnitTests.DomainTests
{
    [TestClass]
    public class CubeTest
    {
        [TestMethod]
        public void Initialize()
        {
            var cube = new Cube();

            Console.WriteLine(cube);
        }

        [TestMethod]
        public void GetFaceByPosition()
        {
            var cube = new Cube();

            Face front = cube.GetFaceByPosition(FacePosition.Front);
            Assert.AreEqual(Color.Green, front.Pieces[0, 0].Color);

            Face up = cube.GetFaceByPosition(front.Position.RotateClockwise(PickType.Vertical));
            Assert.AreEqual(Color.White, up.Pieces[0, 0].Color);
        }
    }
}
