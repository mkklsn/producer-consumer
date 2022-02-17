using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ConsumerFunction
{
    public static class PortingConsumer
    {
        [FunctionName("PortingConsumer")]
        public static void Run(
            [QueueTrigger("porting-queue", Connection = "")] string portingWorkItem,
            ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {portingWorkItem}");

            // process portingWorkItem
        }
    }
}
