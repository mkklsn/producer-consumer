using System.Collections.Generic;

namespace ProducerFunction
{
    public interface IAdoClient
    {
        IEnumerable<WorkItem> GetWorkItems();
    }
}