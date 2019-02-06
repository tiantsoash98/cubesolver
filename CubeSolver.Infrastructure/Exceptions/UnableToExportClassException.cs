using System;

namespace CubeSolver.Infrastructure.Exceptions
{
    public class UnableToExportClassException : Exception
    {
        public UnableToExportClassException()
        {
        }

        public UnableToExportClassException(string message)
            : base(message)
        {
        }

        public UnableToExportClassException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public UnableToExportClassException(Type type)
            : base($"Unable to export class of type {type.GetType().Name}")
        {
            
        }
    }
}
