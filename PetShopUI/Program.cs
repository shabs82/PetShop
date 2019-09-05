using Microsoft.Extensions.DependencyInjection;
using PetShop.Core.ApplicationServices;
using PetShop.Core.ApplicationServices.Services;
using PetShop.Core.DomainServices;
using PetShopInfrastructure;
using PetShopInfrastructure.Repositories;

namespace PetShopUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IPetRepository, PetRepository>();
            serviceCollection.AddScoped<IPetService, PetService>();
            serviceCollection.AddScoped<IPrinter, Printer>();

            FakePetDatabase.InitialiseData();
            ////then build provider 
            var serviceProvider = serviceCollection.BuildServiceProvider();
            IPrinter printer = serviceProvider.GetRequiredService<IPrinter>();
            printer.StartUI();
        }
    }
}
