using CubeSolver.Action.Abstract;
using CubeSolver.Domain.Domains;
using CubeSolver.Domain.Enums;
using CubeSolver.Domain.Extensions;
using System;
using System.Collections.Generic;

namespace CubeSolver.Action.Actions
{
    public abstract class BaseRotationActions: BaseDoubleLayerRotationActions
    {
        public void Rotate(Cube cube, RotationSense rotationSense, PickType pickType, int index)
        {
            RotateLayer(cube, rotationSense, pickType, index);
            RotateAdjacentSide(cube, rotationSense, pickType, index);
        }

        protected void RotateLayer(Cube cube, RotationSense rotationSense, PickType pickType, int index)
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

        protected void RotateAdjacentSide(Cube cube, RotationSense rotationSense, PickType pickType, int index)
        {
            if (index == 2)
                return;

            Face adjacentFace = cube.GetFaceByPosition(GetAdjacentFace(pickType, index));

            RotateMiddlePieces(adjacentFace, rotationSense);
            RotateCornerPieces(adjacentFace, rotationSense);
        }

        protected FacePosition GetEndingRotation(RotationSense rotationSense, PickType pickType)
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

        protected FacePosition GetAdjacentFace(PickType pickType, int index)
        {
            switch (pickType)
            {
                case PickType.Horizontal:
                    if (index == 1)
                        return FacePosition.Up;
                    if (index == 3)
                        return FacePosition.Down;
                    break;

                case PickType.Vertical:
                    if (index == 1)
                        return FacePosition.Left;
                    if (index == 3)
                        return FacePosition.Right;
                    break;
            }

            throw new Exception("Face adjacente inexistante");
        }

        protected void RotateMiddlePieces(Face face, RotationSense rotationSense)
        {
            
        }

        protected void RotateCornerPieces(Face face, RotationSense rotationSense)
        {

        }
    }
}
