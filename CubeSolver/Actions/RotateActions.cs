using CubeSolver.Domain;
using CubeSolver.Enums;
using CubeSolver.Interfaces;
using CubeSolver.Extensions;
using System;

namespace CubeSolver.Actions
{
    public class CubeActions : IRotationActions
    {
        private Cube _cube;

        public CubeActions(Cube cube)
        {
            _cube = cube;
        }

        public void L()
        {
            throw new NotImplementedException();
        }

        public void Lrev()
        {
            throw new NotImplementedException();
        }

        public void R()
        {
            var curFront = _cube.GetFaceByPosition(FacePosition.Front);
            var curUp = _cube.GetFaceByPosition(curFront.Position.RotateClockwise());

            var tmpColor1 = curFront.Pieces[2, 0].Color;
            var tmpColor2 = curFront.Pieces[1, 2].Color;
            var tmpColor3 = curFront.Pieces[2, 2].Color;

            while (curUp.Position != FacePosition.Front)
            {
                Piece topF = curFront.Pieces[2, 0];
                Piece topU = curUp.Pieces[2, 0];


            }

        }

        public void Rrev()
        {
            throw new NotImplementedException();
        }

        public void U()
        {
            throw new NotImplementedException();
        }

        public void Urev()
        {
            throw new NotImplementedException();
        }
    }
}
