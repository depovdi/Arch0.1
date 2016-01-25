using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Rf.Web.Controllers;
using System.Web.Mvc;

namespace Rf.Web.Configuration.Installers
{
    public class ControllerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromAssemblyContaining<FormulierenController>().BasedOn<IController>().LifestylePerWebRequest());
        }
    }
}