using CubeSolver.Action.Abstract;
using CubeSolver.Domain;
using CubeSolver.Infrastructure.Enums;
using CubeSolver.Infrastructure.Extensions;
using System.Collections.Generic;

namespace CubeSolver.Action.Actions
{
    public abstract class BaseRotationActions: BaseDoubleLayerRotationActions
    {
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

        private FacePosition GetEndingRotation(RotationSense rotationSense, PickType pickType)
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
