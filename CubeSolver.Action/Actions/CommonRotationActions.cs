using CubeSolver.Domain;
using CubeSolver.Infrastructure.Enums;
using CubeSolver.Infrastructure.Extensions;
using CubeSolver.Interfaces;
using System.Collections.Generic;

namespace CubeSolver.Actions
{
    public class CommonRotationActions : ICommonRotationActions
    {
        public CommonRotationActions()
        {
        }

        public void L(Cube cube)
        {
            Rotate(cube, RotationSense.Anticlockwise, PickType.Vertical, 1);
        }

        public void Lrev(Cube cube)
        {
            Rotate(cube, RotationSense.Clockwise, PickType.Vertical, 1);
        }

        public void R(Cube cube)
        {
            Rotate(cube, RotationSense.Clockwise, PickType.Vertical, 3);
        }

        public void Rrev(Cube cube)
        {
            Rotate(cube, RotationSense.Anticlockwise, PickType.Vertical, 3);
        }

        public void U(Cube cube)
        {
            Rotate(cube, RotationSense.Clockwise, PickType.Horizontal, 1);
        }

        public void Urev(Cube cube)
        {
            Rotate(cube, RotationSense.Anticlockwise, PickType.Horizontal, 1);
        }

        public void Rotate(Cube cube, RotationSense rotationSense, PickType pickType, int index)
        {
            FacePosition currentFacePosition = FacePosition.Front;
            FacePosition nextFacePosition = currentFacePosition.Rotate(rotationSense, pickType);

            Face curFaceF = cube.GetFaceByPosition(currentFacePosition);
            Face curFaceU = cube.GetFaceByPosition(nextFacePosition);

            List<Color> oldColors = curFaceU.GetPiecesColorRange(pickType, index);
            List<Color> newColors = curFaceF.GetPiecesColorRange(pickType, index);

            FacePosition endPosition = GetEndingRotation(rotationSense, pickType);

            do
            {
                curFaceU.ChangeColorRange(pickType, index, newColors);

                newColors.Clear();
                newColors.AddRange(oldColors);

                currentFacePosition = nextFacePosition;
                nextFacePosition = nextFacePosition.Rotate(rotationSense, pickType);

                curFaceF = cube.GetFaceByPosition(currentFacePosition);
                curFaceU = cube.GetFaceByPosition(nextFacePosition);

                oldColors.Clear();
                oldColors.AddRange(curFaceU.GetPiecesColorRange(pickType, index));

            } while (nextFacePosition != endPosition);
        }

        public FacePosition GetEndingRotation(RotationSense rotationSense, PickType pickType)
        {
            switch (pickType)
            {
                case PickType.Horizontal:
                    return rotationSense == RotationSense.Clockwise ? FacePosition.Left : FacePosition.Right;
                case PickType.Vertical:
                    return rotationSense == RotationSense.Clockwise ? FacePosition.Up : FacePosition.Down;
            }

            return default(FacePosition);
        }
    }
}
