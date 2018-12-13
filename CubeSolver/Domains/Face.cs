using CubeSolver.Enums;

namespace CubeSolver.Domain
{
    public class Face
    {
        public int Size { get; set; }
        public Piece[,] Pieces { get; set;}
        public FacePosition Position { get; set; }

        public Face() { }
        public Face(Color color, int size, FacePosition position)
        {
            Size = size;

            Initialize(size, color, position);
        }

        public void Initialize(int size, Color color, FacePosition position)
        {
            Position = position;
            Pieces = new Piece[size, size];

            int index = 1;
            for(var i = 0; i < size; i++)
            {
                for(var j = 0; j < size; j++)
                {
                    Pieces[i, j] = new Piece(color, i, j);
                    index++;
                }
            }
        }
    }
}
