using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;

namespace CA.Portal
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<CA.DAL.Repositories.IUserRepository, CA.DAL.Repositories.UserRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<CA.DAL.ApplicationDbContext>(new HierarchicalLifetimeManager());
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}