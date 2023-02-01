using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(FunctionApp1.Startup))]

namespace FunctionApp1
{

    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton<IMyService, MyService>();
            builder.Services.AddSingleton<IMyService2, MyService2>();
        }
    }

    public interface IMyService2
    {
        public string GetMyValue();
    }

    public class MyService2 : IMyService2
    {
        public string GetMyValue()
        {
            return "Hello from MyService!";
        }
    }
}
