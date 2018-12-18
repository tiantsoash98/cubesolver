using CubeSolver.Enums;

namespace CubeSolver.Extensions
{
    public static class FacePositionExtensions
    {
        public static FacePosition Rotate(this FacePosition face, Rotation rotation)
        {
            switch (rotation)
            {
                case Rotation.Clockwise:
                    return RotateClockwise(face);
                case Rotation.Anticlockwise:
                    return RotateAnticlockwise(face);
                default:
                    return face;
            }
        }

        public static FacePosition RotateClockwise(this FacePosition face)
        {
            switch (face)
            {
                case FacePosition.Left:
                case FacePosition.Front:
                case FacePosition.Right:
                    return FacePosition.Up;
                case FacePosition.Up:
                    return FacePosition.Back;
                case FacePosition.Down:
                    return FacePosition.Front;
                case FacePosition.Back:
                    return FacePosition.Down;
                default:
                    return face;
            }
        }

        public static FacePosition RotateAnticlockwise(this FacePosition face)
        {
            switch (face)
            {
                case FacePosition.Left:
                case FacePosition.Front:
                case FacePosition.Right:
                    return FacePosition.Down;
                case FacePosition.Up:
                    return FacePosition.Front;
                case FacePosition.Down:
                    return FacePosition.Back;
                case FacePosition.Back:
                    return FacePosition.Up;
                default:
                    return face;
            }
        }
    }
}
