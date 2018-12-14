using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.DomainTests
{
    [TestClass]
    public class CubeTest
    {
        [TestMethod]
        public void Initialize()
        {
            var cube = new CubeSolver.Domain.Cube();

            cube.Initialize(3);

            foreach(var face in cube.Faces)
            {
                Console.WriteLine(face.Position);
                Console.WriteLine("\n");
                
                foreach(var piece in face.Pieces)
                {
                    Console.WriteLine(piece.Position + " " + piece.Color);
                }

                Console.WriteLine("\n\n");
            }
        }
    }
}
