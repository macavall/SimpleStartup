using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using NuGet;

namespace FunctionApp1
{
    public class Timer
    {
        public IMyService _myService;
        public IMyService2 _myService2;
        
        public Timer(IMyService myService, IMyService2 myService2)
        {
            _myService = myService;
            _myService2 = myService2;
        }

        
        [FunctionName("Timer")]
        public void Run([TimerTrigger("* * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            var littleCounter = _myService.counter;
            //_myService.counter = littleCounter + 1;

            log.LogInformation($"MyService Counter Value: {_myService.counter++}");

            var myNuget = new Logger();
            log.LogInformation(myNuget.Log("Hello from NuGet!"));
        }
    }
}
