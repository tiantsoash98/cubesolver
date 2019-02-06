using CubeSolver.Infrastructure.Exceptions;
using CubeSolver.Infrastructure.Interfaces;
using CubeSolver.Infrastructure.Logging;
using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Configuration;

namespace CubeSolver.Infrastructure.Components
{
    public sealed class Manager : IManager, IDisposable
    {
        #region Singleton Properties
        private static IManager instance = null;
        private static object syncRoot = new object();

        public static IManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new Manager();
                        }
                    }
                }

                return instance;
            }
        }
        #endregion

        /// <summary>
        /// MEF Container
        /// </summary>
        private CompositionContainer container { get; set; }
        private AggregateCatalog catalog { get; set; }
        public DirectoryCatalog directoryCatalog { get; private set; }

        #region IDisposable members
        private Boolean isDisposed;

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(Boolean disposing)
        {
            if (!this.isDisposed)
            {
                if (disposing){

                    lock (Manager.syncRoot)
                    {
                        this.container.Dispose();
                        this.catalog.Dispose();
                        this.directoryCatalog.Dispose();

                        Manager.instance = null;
                    }
                }

                this.isDisposed = true;
            }
        }
        #endregion
    

        private Manager()
        {
            this.catalog = new AggregateCatalog();
            this.directoryCatalog = new DirectoryCatalog(ConfigurationManager.AppSettings["DirectoryCatalog"]);
            catalog.Catalogs.Add(directoryCatalog);

            this.container = new CompositionContainer(catalog, true);

            try
            {
                this.container.ComposeParts(this);
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine(compositionException);
            }
        }

        public T Resolve<T>()
        {
            var result =  container.GetExportedValue<T>();

            if(result == null)
            {
                Logs.WriteDebug(new UnableToExportClassException(typeof(T)));
            }

            return result;
        }  
    }
}
