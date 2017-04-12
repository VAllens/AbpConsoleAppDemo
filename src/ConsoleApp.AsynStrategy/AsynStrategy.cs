using System;
using ConsoleApp.Core;

namespace ConsoleApp.AsynStrategy
{
    public class AsynStrategy : IAsynStrategy
    {
        private int _count;

        public virtual void UpdateCount()
        {
            _count++;
            Console.WriteLine("count is " + _count);
        }
    }
}