using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.ActionsTests
{
    [TestClass]
    public class CommonRotationTest
    {
        [TestMethod]
        public void RotateR()
        {
            var cube = new CubeSolver.Domain.Cube();

            var rotateAction = new CubeSolver.Actions.CommonRotationActions();

            rotateAction.R(cube);

            Console.WriteLine(cube);
        }

        [TestMethod]
        public void RotateRrev()
        {
            var cube = new CubeSolver.Domain.Cube();

            var rotateAction = new CubeSolver.Actions.CommonRotationActions();

            rotateAction.Rrev(cube);

            Console.WriteLine(cube);
        }

        [TestMethod]
        public void RotateU()
        {
            var cube = new CubeSolver.Domain.Cube();

            var rotateAction = new CubeSolver.Actions.CommonRotationActions();

            rotateAction.U(cube);

            Console.WriteLine(cube);
        }
    }
}
