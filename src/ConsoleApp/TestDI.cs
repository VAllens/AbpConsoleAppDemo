using Abp.Dependency;
using ConsoleApp.Core;

namespace ConsoleApp
{
    public class TestDI : ISingletonDependency
    {
        public TestDI(IAsynManager manager)
        {
            Manager = manager;
        }

        private IAsynManager Manager { get; }

        public virtual void Run()
        {
            for (var i = 0; i < 100; i++)
                Manager.Instance.UpdateCount();
        }
    }
}