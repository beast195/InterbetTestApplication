using InterbetTestAppplication.Common;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace InterbetTestAppplication.API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = DIHelper.BuildUnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}