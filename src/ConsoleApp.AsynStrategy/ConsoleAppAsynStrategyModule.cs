using System.Reflection;
using Abp.Modules;

namespace ConsoleApp.AsynStrategy
{
    public class ConsoleAppAsynStrategyModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}