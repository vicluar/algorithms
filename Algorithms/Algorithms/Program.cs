using Algorithms.Implementations;
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

            //ExecuteHashTable();
            ExecuteStringBuilder();
        }

        private static void ExecuteStringBuilder()
        {
            var stringBuilderRunner = new StringBuilderRunner();
            var finalString = stringBuilderRunner.ExecuteStringBuilder();

            Console.WriteLine(finalString);

            Console.Read();
        }

        private static void ExecuteHashTable()
        {
            var hashTableRunner = new HashTableRunner();
            var hashTable = hashTableRunner.GetHashTable();

            var result299 = hashTable.LookUp("key299");
            var result375 = hashTable.LookUp("key375");
            var result890 = hashTable.LookUp("key890");
            var result50 = hashTable.LookUp("key50");
            var result689 = hashTable.LookUp("key689");
            var result2000 = hashTable.LookUp("key2000");

            Console.WriteLine($"Key: {result299?.Key} - Data: {result299?.Data}");
            Console.WriteLine($"Key: {result375?.Key} - Data: {result375?.Data}");
            Console.WriteLine($"Key: {result890?.Key} - Data: {result890?.Data}");
            Console.WriteLine($"Key: {result50?.Key} - Data: {result50?.Data}");
            Console.WriteLine($"Key: {result689?.Key} - Data: {result689?.Data}");
            Console.WriteLine($"Key: {result2000?.Key} - Data: {result2000?.Data}");

            Console.Read();
        }
    }
}
