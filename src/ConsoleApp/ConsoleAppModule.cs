using System.Reflection;
using Abp.Modules;
using ConsoleApp.Core;

namespace ConsoleApp
{
    [DependsOn(typeof(ConsoleAppCoreModule))]
    public class ConsoleAppModule : AbpModule
    {
        public override void Initialize()
        {
            //IocManager.Register<TestCI>();

            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}