using CubeSolver.Domain.Domains;

namespace CubeSolver.Action.Abstract
{
    public abstract class BaseCommonRotationActions
    {
        public abstract void R(Cube cube);
        public abstract void Rrev(Cube cube);
        public abstract void L(Cube cube);
        public abstract void Lrev(Cube cube);
        public abstract void U(Cube cube);
        public abstract void Urev(Cube cube);
        public abstract void D(Cube cube);
        public abstract void Drev(Cube cube);
        public abstract void M(Cube cube);
        public abstract void Mrev(Cube cube);
        public abstract void E(Cube cube);
        public abstract void Erev(Cube cube);

        public void R2(Cube cube)
        {
            R(cube);
            R(cube);
        }

        public void Rrev2(Cube cube)
        {
            Rrev(cube);
            Rrev(cube);
        }

        public void L2(Cube cube)
        {
            L(cube);
            L(cube);
        }

        public void Lrev2(Cube cube)
        {
            Lrev(cube);
            Lrev(cube);
        }

        public void U2(Cube cube)
        {
            U2(cube);
            U2(cube);
        }

        public void Urev2(Cube cube)
        {
            Urev(cube);
            Urev(cube);
        }

        public void D2(Cube cube)
        {
            D(cube);
            D(cube);
        }

        public void Drev2(Cube cube)
        {
            Drev(cube);
            Drev(cube);
        }

        public void M2(Cube cube)
        {
            M(cube);
            M(cube);
        }

        public void Mrev2(Cube cube)
        {
            Mrev(cube);
            Mrev(cube);
        }

        public void E2(Cube cube)
        {
            E(cube);
            E(cube);
        }

        public void Erev2(Cube cube)
        {
            Erev(cube);
            Erev(cube);
        }
    }
}
