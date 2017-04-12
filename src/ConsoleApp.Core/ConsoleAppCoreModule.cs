using System.Reflection;
using Abp.Modules;
using Castle.MicroKernel.Registration;

namespace ConsoleApp.Core
{
    public class ConsoleAppCoreModule : AbpModule
    {
        public override void Initialize()
        {
            //IocManager.IocContainer.Register(Classes.FromAssemblyInThisApplication()
            //        .BasedOn<ISingletonDependency>()
            //        .WithService.Self()
            //        .WithService.DefaultInterfaces()
            //        .LifestyleSingleton());

            //IocManager.IocContainer.Register(Classes.FromAssemblyInThisApplication()
            //        .BasedOn<ITransientDependency>()
            //        .WithService.Self()
            //        .WithService.DefaultInterfaces()
            //        .LifestyleTransient());

            //IocManager.IocContainer.Register(Classes.FromAssemblyInThisApplication().BasedOn<IStrategy>());

            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}