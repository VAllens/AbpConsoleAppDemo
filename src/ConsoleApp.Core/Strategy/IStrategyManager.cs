using Abp.Domain.Services;

namespace ConsoleApp.Core
{
    public interface IStrategyManager<out TStrategy> : IDomainService
    {
        TStrategy Instance { get; }
    }
}