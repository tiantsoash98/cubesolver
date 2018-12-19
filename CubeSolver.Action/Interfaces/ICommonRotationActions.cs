using CubeSolver.Domain;

namespace CubeSolver.Action.Interfaces
{
    public interface ICommonRotationActions
    {
        void R(Cube cube);
        void Rrev(Cube cube);
        void L(Cube cube);
        void Lrev(Cube cube);
        void U(Cube cube);
        void Urev(Cube cube);
    }
}
