using System.Collections.Generic;
using System.Linq;

namespace ProducerFunction
{
    public class AdoClient : IAdoClient
    {
        public IEnumerable<WorkItem> GetWorkItems()
        {
            return Enumerable.Empty<WorkItem>();
        }
    }
}