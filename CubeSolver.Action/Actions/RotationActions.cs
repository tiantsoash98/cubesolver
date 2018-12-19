using CubeSolver.Action.Interfaces;
using CubeSolver.Domain;
using CubeSolver.Infrastructure.Enums;

namespace CubeSolver.Action.Actions
{
    public class RotationActions: BaseRotationActions, ICommonRotationActions, IUncommonRotationActions
    {
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

        public void D(Cube cube)
        {
            Rotate(cube, RotationSense.Anticlockwise, PickType.Horizontal, 3);
        }

        public void Drev(Cube cube)
        {
            Rotate(cube, RotationSense.Clockwise, PickType.Horizontal, 3);
        }

        public void M(Cube cube)
        {
            Rotate(cube, RotationSense.Clockwise, PickType.Vertical, 2);
        }

        public void Mrev(Cube cube)
        {
            Rotate(cube, RotationSense.Anticlockwise, PickType.Vertical, 2);
        }
    }
}
