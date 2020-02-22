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
            _hashTable = new LinkedList[int.MaxValue];
        }

        public void AddElement(DataValue dataValue)
        {
            var hash = HashKey(dataValue.Key);
            var node = new Node(dataValue);

            if (_hashTable[hash] == null)
            {
                _hashTable[hash] = new LinkedList(node);
            }
            else
            {
                var lastNode = _hashTable[hash].GetLastNode();
                lastNode.AddNextNode(node);
            }
        }
     
        public DataValue LookUp(string key)
        {
            return null;
        }

        private int HashKey(string key)
        {
            return key.GetHashCode();
        }
    }
}
