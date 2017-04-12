using Abp.Dependency;

namespace ConsoleApp.Core
{
    public interface IAsynStrategy : IStrategy, ITransientDependency
    {
        void UpdateCount();
    }
}