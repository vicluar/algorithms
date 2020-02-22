using Algorithms.Implementations.MyOwnHashTable;
using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kicking off the process");

            var hashTable = new VicDHashTable();
            var dataValues = GetDataValues();
           
            foreach (var dataValue in dataValues)
            {
                hashTable.AddElement(dataValue);
            }

            var result299 = hashTable.LookUp("key299");
            var result375 = hashTable.LookUp("key375");
            var result890 = hashTable.LookUp("key890");
            var result50 = hashTable.LookUp("key50");
            var result689 = hashTable.LookUp("key689");

            Console.WriteLine($"Key: {result299.Key} - Data: {result299.Data}");
            Console.WriteLine($"Key: {result375.Key} - Data: {result375.Data}");
            Console.WriteLine($"Key: {result890.Key} - Data: {result890.Data}");
            Console.WriteLine($"Key: {result50.Key} - Data: {result50.Data}");
            Console.WriteLine($"Key: {result50.Key} - Data: {result50.Data}");
        }

        private static List<DataValue> GetDataValues()
        {
            var result = new List<DataValue>();

            for (int i = 0; i < 1000; i++)
            {
                result.Add(new DataValue($"key{i}", $"data{i}"));
            }

            return result;
        }
    }
}
