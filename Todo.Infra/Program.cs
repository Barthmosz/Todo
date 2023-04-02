
using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;

namespace Todo.Infra
{
    public static class Program
    {
        static void Main()
        {
            Console.WriteLine("Applying migrations");
            IWebHost webHost = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .Build();
            Console.WriteLine("Done");
        }
    }
}