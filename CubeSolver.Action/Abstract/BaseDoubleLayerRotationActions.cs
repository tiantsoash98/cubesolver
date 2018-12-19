using CubeSolver.Domain;

namespace CubeSolver.Action.Abstract
{
    public abstract class BaseDoubleLayerRotationActions: BaseComplexRotationActions
    {
        public void Rdouble(Cube cube)
        {
            R(cube);
            M(cube);
        }

        public void RdoubleRev(Cube cube)
        {
            Rrev(cube);
            Mrev(cube);
        }

        public void Ldouble(Cube cube)
        {
            L(cube);
            Mrev(cube);
        }

        public void LdoubleRev(Cube cube)
        {
            Lrev(cube);
            M(cube);
        }

        public void Udouble(Cube cube)
        {
            U(cube);
            Erev(cube);
        }

        public void UdoubleRev(Cube cube)
        {
            Urev(cube);
            E(cube);
        }

        public void Ddouble(Cube cube)
        {
            D(cube);
            E(cube);
        }

        public void DdoubleRev(Cube cube)
        {
            Drev(cube);
            Erev(cube);
        }

        public void Fdouble(Cube cube)
        {
            Y(cube);
            L(cube);
            Mrev(cube);
        }

        public void FdoubleRev(Cube cube)
        {
            Y(cube);
            Lrev(cube);
            M(cube);
        }

        public void Bdouble(Cube cube)
        {
            Yrev(cube);
            L(cube);
            Mrev(cube);
        }

        public void BdoubleRev(Cube cube)
        {
            Yrev(cube);
            Lrev(cube);
            M(cube);
        }
    }
}
