using LottoWeb.Services;
using LottoWeb.Services.Interfaces;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace LottoWeb
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<IOpenDrawsService, OpenDrawsService>();
          

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}