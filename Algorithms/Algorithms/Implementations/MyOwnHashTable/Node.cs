using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Implementations.MyOwnHashTable
{
    public class Node
    {
        public DataValue DataValue { get; private set; }
        public Node Next { get; private set; }

        public Node(DataValue dataValue)
        {
            DataValue = dataValue;
        }

        public void AddNextNode(Node nextNode)
        {
            Next = nextNode;
        }

        public bool HasKey(string key)
        {
            return DataValue.KeyEquals(key);
        }
    }
}
