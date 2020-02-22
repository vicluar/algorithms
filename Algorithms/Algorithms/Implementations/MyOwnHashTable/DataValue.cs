using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Implementations.MyOwnHashTable
{
    public class DataValue
    {
        public string Key { get; private set; }
        public string Data { get; private set; }

        public DataValue(string key, string data)
        {
            Key = key;
            Data = data;
        }

        public bool KeyEquals(string key)
        {
            return Key.Equals(key);
        }
    }
}
