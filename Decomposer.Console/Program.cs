using System;
using Decomposer.Domain.Creator;
using Decomposer.Domain.Factory;
using Decomposer.Services;
using Decomposer.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
namespace Decomposer.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection serviceCollection = new ServiceCollection();
            var serviceProvider = ConfigureServices(serviceCollection);
            var decomposeConsoleService = serviceProvider.GetService<IDecomposeConsoleService>();
            var decomposeService = serviceProvider.GetService<IDecomposeService>();
            var numberFactory = serviceProvider.GetService<NumberFactoryMethod>();

            var numberToDecompose = numberFactory.MakeDecomposeNumber(decomposeConsoleService.WriterConsoleAndReturnNumber());
            decomposeService.DecompouseNumber(numberToDecompose);
            var resultNumber = numberFactory.ReturnResult(numberToDecompose);
            decomposeConsoleService.FinishApplication(resultNumber);
        }

        public static ServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IDecomposeConsoleService, DecomposeConsoleService>();
            services.AddScoped<IDecomposeService, DecomposeService>();
            services.AddSingleton<NumberFactoryMethod, NumberFactory>();
            return services.BuildServiceProvider();
        }
    }
}
