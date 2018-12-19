using CubeSolver.Domain;

namespace CubeSolver.Action.Interfaces
{
    public interface IUncommonRotationActions
    {
        void D(Cube cube);
        void Drev(Cube cube);
        void M(Cube cube);
        void Mrev(Cube cube);
    }
}
