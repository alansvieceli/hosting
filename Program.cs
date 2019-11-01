using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = WebHost
                .CreateDefaultBuilder(args)
                .UseStartup<StartUp>()
                .Build();

            host.Run();
        }
    }
}
