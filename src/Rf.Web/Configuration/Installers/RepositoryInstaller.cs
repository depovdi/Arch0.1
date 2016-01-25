using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Rf.Repositories;
using Rf.Repositories.Contexts;
using Rf.Repositories.Interfaces;
using System.Data.Entity; 

namespace Rf.Web.Configuration.Installers
{
    public class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<DbContext>()
                    .ImplementedBy<FormulierDbContext>()
                    .LifeStyle.PerWebRequest
            );

            container.Register(
                Component.For(typeof(IRepository<>))
                    .ImplementedBy(typeof(RepositoryBase<>))
                    .LifeStyle.PerWebRequest
            );
        }
    }
}