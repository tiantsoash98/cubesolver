using CubeSolver.Infrastructure.Interfaces;
using System;
using System.ComponentModel.Composition;

namespace CubeSolver.Infrastructure.Components
{
    [Export(typeof(IOutput))]
    public class DebugWriter : IOutput
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
