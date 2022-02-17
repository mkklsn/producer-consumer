using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ProducerFunction
{
    public static class KiteIngestionProducer
    {
        [FunctionName("KiteIngestionProducer")]
        public static void Run([TimerTrigger("0 */15 * * * *")] TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
