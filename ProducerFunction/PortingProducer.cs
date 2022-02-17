using System;
using System.Collections.Generic;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ProducerFunction
{
    public class PortingProducer
    {
        private readonly IAdoClient AdoClient;

        public PortingProducer(IAdoClient adoClient)
        {
            AdoClient = adoClient;
        }

        [FunctionName("PortingProducer")]
        public void Run(
            [TimerTrigger("0 */15 * * * *")] TimerInfo myTimer,
            [Queue("porting-queue")] ICollector<WorkItem> collector,
            ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            // sample list of work items to port from workload source
            IEnumerable<WorkItem> workItems = new List<WorkItem>();

            // looks like there's no method to add a list of messages in one go
            // so queue one by one
            foreach (WorkItem item in workItems)
            {
                log.LogInformation($"Queued item: {item.Content}");
                collector.Add(item);
            }
        }
    }
}
