using Orleans;
using System;
using System.Threading.Tasks;
using Test.Interfaces;
using Microsoft.Extensions.Logging;

namespace Test.Implements
{
    public class HelloGrain : Grain, IHello
    {
        private readonly ILogger logger;

        public HelloGrain(ILogger<HelloGrain> logger)
        {
            this.logger = logger;
        }
        public Task<String> SayHello(String greeting)
        {
            logger.LogInformation($"SayHello message received: greeting = '{greeting}'");
            return Task.FromResult($"You said: '{greeting}', I say: Hello!");
        }
    }
}
