using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(ExploreAzureFunction.Startup))]

namespace ExploreAzureFunction{
    public class Startup : FunctionsStartup {

        public override void Configure(IFunctionsHostBuilder builder){
            // You can add Dependencies here
            builder.Services.AddLogging();
        }
    }
}

