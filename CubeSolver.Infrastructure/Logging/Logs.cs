using CubeSolver.Infrastructure.Components;
using CubeSolver.Infrastructure.Interfaces;
using System;

namespace CubeSolver.Infrastructure.Logging
{
    public static class Logs
    {
        public static void WriteDebug(string message)
        {
            IOutput output = Manager.Instance.Resolve<IOutput>();

            string debug = string.Format("{0}: {1}", DateTime.Now.ToString(), message);
            output.Write(debug);
        }

        public static void WriteDebug(Exception exception)
        {
            IOutput output = Manager.Instance.Resolve<IOutput>();

            string debug = string.Format("{0} - {1}: {2}", DateTime.Now.ToString(), exception.GetType().Name, exception.Message);
            output.Write(debug);
        }
    }
}
