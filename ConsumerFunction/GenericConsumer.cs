using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ConsumerFunction
{
    public static class GenericConsumer
    {
        [FunctionName("GenericConsumer")]
        public static void Run([QueueTrigger("myqueue-items", Connection = "")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
