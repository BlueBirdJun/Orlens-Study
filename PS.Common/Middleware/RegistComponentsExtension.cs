using Microsoft.Extensions.DependencyInjection;
//using Power.Feeds;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace PS.Common.Middleware
{
    public static class RegistComponentsExtension
    {
        public static void AddRegistComponents(this IServiceCollection serviceCollection)
        {
            var location = Path.GetDirectoryName(typeof(StartUp).Assembly.Location);
            foreach (var filename in Directory.GetFiles(location, "*.dll"))
            {
                var assembly = Assembly.LoadFrom(filename);
                foreach (var type in assembly.GetTypes())
                {
                    if (!(type.GetCustomAttribute(typeof(RegisterAttribute)) is RegisterAttribute registerAttribute))
                        continue;

                    Console.WriteLine($"RegistrationType: {registerAttribute.RegistrationType}, {type}");
                    serviceCollection.AddSingleton(registerAttribute.RegistrationType, type);
                }
            }
        }
    }
}
