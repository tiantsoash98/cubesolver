using CubeSolver.Enums;
using System;

namespace CubeSolver.Domain
{
    public class Piece
    {
        public Color Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public PiecePosition Position
        {
            get
            {
                return GetPosition();
            }
        }


        public Piece() { }
        public Piece(Color color, int x, int y)
        {
            Color = Color;
            X = x;
            Y = y;
        }

        public PiecePosition GetPosition()
        {
            if (X == 0 && Y == 0
                || X == 2 && Y == 0
                || X == 0 && Y == 2
                || X == 2 && Y == 2)
            {
                return PiecePosition.Corner;
            }
                
            if (X == 1 && Y == 0
                || X == 0 && Y == 1
                || X == 2 && Y == 1
                || X == 1 && Y == 2)
            {
                return PiecePosition.Middle;
            }

            if(X == 1 && Y == 1)
            {
                return PiecePosition.Center;
            }

            throw new Exception("Position invalide");
        }
    }
}
