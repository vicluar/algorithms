using Algorithms.Implementations.MyOwnHashTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Implementations
{
    public class HashTableRunner
    {
        public HashTableRunner()
        {
        }

        public VicDHashTable GetHashTable()
        {
            var dataValues = GetDataValues();
            var hashTable = new VicDHashTable();

            foreach (var dataValue in dataValues)
            {
                hashTable.AddElement(dataValue);
            }

            return hashTable;
        }

        private List<DataValue> GetDataValues()
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
