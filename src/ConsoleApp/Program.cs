using System;
using System.IO;
using Abp;
using Abp.PlugIns;

namespace ConsoleApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Create AbpBootstrapper.");
            using (var booter = AbpBootstrapper.Create<ConsoleAppModule>())
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PlugIns");
                Console.WriteLine("path is " + path);
                booter.PlugInSources.AddFolder(path);
                Console.WriteLine("Added PlugIns Directory is completed.");
                booter.Initialize();
                Console.WriteLine("Initialize DI is completed.");

                var test = booter.IocManager.Resolve<TestDI>();
                test.Run();

                var test2 = booter.IocManager.Resolve<TestDI>();
                test2.Run();
            }
            Console.WriteLine("Dispose AbpBootstrapper.");

            Console.ReadKey();
        }
    }
}