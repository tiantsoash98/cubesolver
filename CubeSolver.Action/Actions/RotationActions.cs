using CubeSolver.Domain;
using CubeSolver.Infrastructure.Enums;

namespace CubeSolver.Action.Actions
{
    public class RotationActions: CubeRotationActions
    {
        public override void L(Cube cube)
        {
            Rotate(cube, RotationSense.Counterclockwise, PickType.Vertical, 1);
        }

        public override void Lrev(Cube cube)
        {
            Rotate(cube, RotationSense.Clockwise, PickType.Vertical, 1);
        }

        public override void R(Cube cube)
        {
            Rotate(cube, RotationSense.Clockwise, PickType.Vertical, 3);
        }

        public override void Rrev(Cube cube)
        {
            Rotate(cube, RotationSense.Counterclockwise, PickType.Vertical, 3);
        }

        public override void U(Cube cube)
        {
            Rotate(cube, RotationSense.Clockwise, PickType.Horizontal, 1);
        }

        public override void Urev(Cube cube)
        {
            Rotate(cube, RotationSense.Counterclockwise, PickType.Horizontal, 1);
        }

        public override void D(Cube cube)
        {
            Rotate(cube, RotationSense.Counterclockwise, PickType.Horizontal, 3);
        }

        public override void Drev(Cube cube)
        {
            Rotate(cube, RotationSense.Clockwise, PickType.Horizontal, 3);
        }

        public override void M(Cube cube)
        {
            Rotate(cube, RotationSense.Clockwise, PickType.Vertical, 2);
        }

        public override void Mrev(Cube cube)
        {
            Rotate(cube, RotationSense.Counterclockwise, PickType.Vertical, 2);
        }

        public override void E(Cube cube)
        {
            Rotate(cube, RotationSense.Counterclockwise, PickType.Horizontal, 2);
        }

        public override void Erev(Cube cube)
        {
            Rotate(cube, RotationSense.Clockwise, PickType.Horizontal, 2);
        }
    }
}
