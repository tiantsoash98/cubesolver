using Microsoft.VisualStudio.TestTools.UnitTesting;
using CubeSolver.Domain.Enums;
using System.Collections.Generic;
using CubeSolver.Domain.Domains;

namespace UnitTests.DomainTests
{
    [TestClass]
    public class FaceTest
    {
        [TestMethod]
        public void GetPiecesRange()
        {
            var cube = new Cube();
            var pieces = cube.Faces[0].GetPiecesRange(PickType.Horizontal, 1);

            pieces.ForEach(x =>
            {
                System.Console.WriteLine(x.X + " " + x.Y);
            });
        }

        [TestMethod]
        public void ChangeColorRange()
        {
            var cube = new Cube();

            List<Color> colors = new List<Color>{ Color.Blue, Color.Green, Color.Red };

            cube.Faces[0].ChangeColorRange(PickType.Horizontal, 1, colors);

            System.Console.WriteLine(cube);
        }
    }
}
