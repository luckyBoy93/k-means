using System.Collections.Generic;

namespace k_means
{
    interface IMetrics<T>
    {

        double Calculate(T[] v1, T[] v2);

        T[] GetCentroid(IList<T[]> data);
    }
}
