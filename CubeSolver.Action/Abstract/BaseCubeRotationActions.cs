using CubeSolver.Domain.Domains;

namespace CubeSolver.Action.Abstract
{
    public abstract class BaseCubeRotationActions: BaseCommonRotationActions
    {
        public abstract void X(Cube cube);
        public abstract void Xrev(Cube cube);
        public abstract void Y(Cube cube);
        public abstract void Yrev(Cube cube);
        public abstract void Z(Cube cube);
        public abstract void Zrev(Cube cube);
    }
}
