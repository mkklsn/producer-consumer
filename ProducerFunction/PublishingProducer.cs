using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ProducerFunction
{
    public static class PublishingProducer
    {
        [FunctionName("PublishingProducer")]
        public static void Run([QueueTrigger("myqueue-items", Connection = "")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
