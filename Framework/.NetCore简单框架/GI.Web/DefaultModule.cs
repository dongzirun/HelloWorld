using Autofac;
using GI.IService;
using GI.Service;
using System.Reflection;

namespace GI.Web
{
    public class AutofacDefaultModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            //注入服务
            //builder.RegisterType<UserService>().As<IUserService>().PropertiesAutowired();


            Assembly[] assemblies = new Assembly[] { Assembly.Load("GI.Service") };
            builder.RegisterAssemblyTypes(assemblies)
            .Where(type => !type.IsAbstract
                    && typeof(IServiceSupport).IsAssignableFrom(type))
                    .AsImplementedInterfaces().PropertiesAutowired();
        }
    }
}