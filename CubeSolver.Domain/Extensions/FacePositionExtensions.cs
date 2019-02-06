using CubeSolver.Domain.Enums;

namespace CubeSolver.Domain.Extensions
{
    public static class FacePositionExtensions
    {
        public static FacePosition Rotate(this FacePosition face, RotationSense rotationSense, PickType pickType)
        {
            switch (rotationSense)
            {
                case RotationSense.Clockwise:
                    return RotateClockwise(face, pickType);
                case RotationSense.Counterclockwise:
                    return RotateAnticlockwise(face, pickType);
                default:
                    return face;
            }
        }

        public static FacePosition RotateClockwise(this FacePosition face, PickType pickType)
        {
            if(pickType == PickType.Vertical)
            {
                switch (face)
                {        
                    case FacePosition.Front:
                        return FacePosition.Up;
                    case FacePosition.Up:
                        return FacePosition.Back;
                    case FacePosition.Down:
                        return FacePosition.Front;
                    case FacePosition.Back:
                        return FacePosition.Down;
                    case FacePosition.Right:
                    case FacePosition.Left:
                    default:
                        return face;
                }
            }
            else if (pickType == PickType.Horizontal)
            {
                switch (face)
                {
                    case FacePosition.Left:
                        return FacePosition.Back;
                    case FacePosition.Front:
                        return FacePosition.Left;
                    case FacePosition.Right:
                        return FacePosition.Front;
                    case FacePosition.Back:
                        return FacePosition.Right;
                    case FacePosition.Up:
                    case FacePosition.Down:
                    default:
                        return face;
                }
            }

            return face;
        }

        public static FacePosition RotateAnticlockwise(this FacePosition face, PickType pickType)
        {
            if (pickType == PickType.Vertical)
            {
                switch (face)
                {
                    case FacePosition.Front:
                        return FacePosition.Down;
                    case FacePosition.Up:
                        return FacePosition.Front;
                    case FacePosition.Down:
                        return FacePosition.Back;
                    case FacePosition.Back:
                        return FacePosition.Up;
                    case FacePosition.Right:
                    case FacePosition.Left:
                    default:
                        return face;
                }
            }
            else if (pickType == PickType.Horizontal)
            {
                switch (face)
                {
                    case FacePosition.Left:
                        return FacePosition.Front;
                    case FacePosition.Front:
                        return FacePosition.Right;
                    case FacePosition.Right:
                        return FacePosition.Back;
                    case FacePosition.Back:
                        return FacePosition.Left;
                    case FacePosition.Up:
                    case FacePosition.Down:
                    default:
                        return face;
                }
            }

            return face;
        }
    }
}
