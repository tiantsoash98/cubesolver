using CubeSolver.Domain;

namespace CubeSolver.Action.Abstract
{
    public abstract class BaseComplexRotationActions: BaseCubeRotationActions
    {
        public void F(Cube cube)
        {
            Y(cube);
            L(cube);
            Yrev(cube);
        }

        public void Frev(Cube cube)
        {
            Y(cube);
            Lrev(cube);
            Yrev(cube);
        }

        public void B(Cube cube)
        {
            Yrev(cube);
            L(cube);
            Y(cube);
        }

        public void Brev(Cube cube)
        {
            Yrev(cube);
            Lrev(cube);
            Y(cube);
        }

        public void F2(Cube cube)
        {
            Y(cube);
            L2(cube);
            Yrev(cube);
        }

        public void Frev2(Cube cube)
        {
            Y(cube);
            Lrev2(cube);
            Yrev(cube);
        }

        public void B2(Cube cube)
        {
            Yrev(cube);
            L2(cube);
            Y(cube);
        }

        public void Brev2(Cube cube)
        {
            Yrev(cube);
            Lrev2(cube);
            Y(cube);
        }
    }
}
