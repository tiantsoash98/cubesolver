using CubeSolver.Enums;
using System;

namespace CubeSolver.Domain
{
    public class Cube
    {
        public int Size { get; set; }
        public Face[] Faces { get; set; }

        public Cube(int size = 3)
        {
            Size = 3;
        }

        public void Initialize(int size)
        {
            // Green - Front
            // White - Top
            // Yellow - Bottom
            // Red - Right
            // Blue - Back
            // Orange - Left

            Faces = new Face[6];
            Faces[0] = new Face(Color.Orange, Size, FacePosition.Left);
            Faces[1] = new Face(Color.Green, Size, FacePosition.Front);
            Faces[2] = new Face(Color.Red, Size, FacePosition.Right);
            Faces[3] = new Face(Color.Blue, Size, FacePosition.Back);
            Faces[4] = new Face(Color.White, Size, FacePosition.Up);
            Faces[5] = new Face(Color.Yellow, Size, FacePosition.Down);
        }
    }
}
