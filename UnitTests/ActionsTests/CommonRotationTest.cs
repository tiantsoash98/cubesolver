using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CubeSolver.Action.Actions;

namespace UnitTests.ActionsTests
{
    [TestClass]
    public class CommonRotationTest
    {
        [TestMethod]
        public void RotateR()
        {
            var cube = new CubeSolver.Domain.Cube();

            var rotateAction = new RotationActions();

            rotateAction.R(cube);

            Console.WriteLine(cube);
        }

        [TestMethod]
        public void RotateRrev()
        {
            var cube = new CubeSolver.Domain.Cube();

            var rotateAction = new RotationActions();

            rotateAction.Rrev(cube);

            Console.WriteLine(cube);
        }

        [TestMethod]
        public void RotateU()
        {
            var cube = new CubeSolver.Domain.Cube();

            var rotateAction = new RotationActions();

            rotateAction.U(cube);

            Console.WriteLine(cube);
        }
    }
}
