using CubeSolver.Infrastructure.Enums;
using System.Linq;
using System.Text;

namespace CubeSolver.Domain
{
    public class Cube
    {
        public int Size { get; set; }
        public Face[] Faces { get; set; }

        public Cube(int size = 3, bool initialize = true)
        {
            Size = size;

            if (initialize)
            {
                Initialize(size);         
            }
        }

        public void Initialize(int size)
        {
            InitFaces(size);   
        }

        public void InitFaces(int size)
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

        public Face GetFaceByPosition(FacePosition position)
        {
            return Faces.First(f => f.Position == position);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var face in Faces)
            {
                sb.AppendLine(face.Position.ToString());
                sb.AppendLine();

                foreach (var piece in face.Pieces)
                {
                    sb.AppendLine("[" + piece.X + ", " + piece.Y + "] " + piece.Color);
                }

                sb.AppendLine("\n\n");
            }

            return sb.ToString();
        }
    }
}
