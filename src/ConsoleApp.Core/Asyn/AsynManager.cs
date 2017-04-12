using Abp.Domain.Services;

namespace ConsoleApp.Core
{
    public class AsynManager : DomainService, IAsynManager
    {
        public AsynManager(IAsynStrategy instance)
        {
            Instance = instance;
        }

        public virtual IAsynStrategy Instance { get; }
    }
}