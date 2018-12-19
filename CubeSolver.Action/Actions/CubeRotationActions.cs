using CubeSolver.Domain;

namespace CubeSolver.Action.Actions
{
    public abstract class CubeRotationActions : BaseRotationActions
    {
        public override void X(Cube cube)
        {
            Lrev(cube);
            M(cube);
            R(cube);
        }

        public override void Xrev(Cube cube)
        {
            L(cube);
            Mrev(cube);
            Rrev(cube);
        }

        public override void Y(Cube cube)
        {
            U(cube);
            Erev(cube);
            Drev(cube);
        }

        public override void Yrev(Cube cube)
        {
            Urev(cube);
            E(cube);
            D(cube);
        }

        public override void Z(Cube cube)
        {
            Y(cube);
            Xrev(cube);
            Yrev(cube);
        }

        public override void Zrev(Cube cube)
        {
            Y(cube);
            X(cube);
            Yrev(cube);
        }
    }
}
