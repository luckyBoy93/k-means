using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace k_means
{
    class Program
    {
        public static void KMeansTest()
        {
            int _maxIterations = 100000; 
            int _countOfCluster = 4; 
            
            Kmeans clusterization = new Kmeans(_countOfCluster, _maxIterations);
            List<DataItem<double>> data = new List<DataItem<double>>();
            Dictionary<int,List<DataItem<double>>> fullData = new Dictionary<int,List<DataItem<double>>>();
            data.Add(new DataItem<double>(new double[4] { 1, 3, 1, 3}));
            data.Add(new DataItem<double>(new double[4] { 2, 2, 2, 2}));
            data.Add(new DataItem<double>(new double[4] { 3, 1, 3, 1}));

            data.Add(new DataItem<double>(new double[4] { 10, 10, 10, 11}));
            data.Add(new DataItem<double>(new double[4] { 12, 10, 12, 12}));
            data.Add(new DataItem<double>(new double[4] { 14, 10, 14, 13}));

            data.Add(new DataItem<double>(new double[4] { 21, 21, 21, 21}));
            data.Add(new DataItem<double>(new double[4] { 22, 21, 22, 22}));
            data.Add(new DataItem<double>(new double[4] { 23, 22, 23, 23}));
                                                     
            data.Add(new DataItem<double>(new double[4] { 35, 31, 35, 31}));
            data.Add(new DataItem<double>(new double[4] { 32, 32, 32, 32}));
            data.Add(new DataItem<double>(new double[4] { 31, 36, 31, 33}));
            Dictionary<double, double[]> classItem = new Dictionary<double, double[]>();
            ClusterizationResult<double> c = clusterization.MakeClusterization(data); // запуск кластеризации
            
           foreach(var kvp in c.Clusterization)
           {
               Console.WriteLine("Центр масс: (" + kvp.Key[0] + ", " + kvp.Key[1] + ", " + kvp.Key[2] + ") : \n точки кластера:");
               foreach (var str in kvp.Value.ToList<DataItem<double>>())
               {
                   Console.WriteLine(" (" + str.Input[0] + ", " + str.Input[1] + ", " + str.Input[2] + ")");
               }
            }
           Console.ReadKey();
        }

        static void Main(string[] args)
        {
            KMeansTest();
        }
    }
}
