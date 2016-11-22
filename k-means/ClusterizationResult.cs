using System.Collections.Generic;

namespace k_means
{
    public class ClusterizationResult<T>
    {
        public List<T[]> CenterMass { get; set; }

        public Dictionary<T[], IList<DataItem<T>>> Clusterization { get; set; }

        public double Cost { get; set; }
    }
}
