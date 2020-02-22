using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Implementations.MyOwnHashTable
{
    public class VicDHashTable
    {
        private LinkedList[] _hashTable;

        public VicDHashTable()
        {
            _hashTable = new LinkedList[400];
        }

        public void AddElement(DataValue dataValue)
        {
            var hash = HashKey(dataValue.Key);
            var hashTableIndex = GetHashTableIndex(hash);
            var node = new Node(dataValue);

            if (_hashTable[hashTableIndex] == null)
            {
                _hashTable[hashTableIndex] = new LinkedList(node);
            }
            else
            {
                var lastNode = _hashTable[hashTableIndex].GetLastNode();
                lastNode.AddNextNode(node);
            }
        }
     
        public DataValue LookUp(string key)
        {
            var hash = HashKey(key);
            var hashTableIndex = GetHashTableIndex(hash);

            if (_hashTable[hashTableIndex] == null)
                return default;

            var linkedList = _hashTable[hashTableIndex];
            var node = linkedList.GetNodeByKey(key);

            return node?.DataValue;
        }

        private int HashKey(string key)
        {
            return Math.Abs(key.GetHashCode());
        }

        private int GetHashTableIndex(int hash)
        {
            return hash % 400;
        }
    }
}
