using CubeSolver.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CubeSolver.Domain.Domains
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

        public List<Piece> GetPiecesRange(PickType pickType, int index)
        {
            if(index > Size)
            {
                throw new Exception("L'index spécifié est supérieur à la taille du cube");
            }

            List<Piece> pieces = new List<Piece>();
            
            switch (pickType)
            {
                case PickType.Vertical:

                    for(int i = 0; i < Size; i++)
                    {
                        pieces.Add(Pieces[index - 1, i]);
                    }
                    break;

                case PickType.Horizontal:

                    for (int i = 0; i < Size; i++)
                    {
                        pieces.Add(Pieces[i, index - 1]);
                    }
                    break;
            }

            return pieces;
        }

        public List<Color> GetPiecesColorRange(PickType pickType, int index)
        {
            return GetPiecesRange(pickType, index).Select(p => p.Color).ToList();
        }

        public void ChangeColorRange(PickType pickType, int index, List<Color> colors)
        {
            List<Piece> pieces = GetPiecesRange(pickType, index);

            if(pieces.Count != colors.Count)
            {
                throw new Exception("La taille de la liste des couleurs diffère de celle du cube");
            }

            for(int i = 0; i < Size; i++)
            {
                pieces[i].Color = colors[i];
            }
        }
    }
}
