using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Implementations.MyOwnHashTable
{
    public class LinkedList
    {
        public Node HeadNode { get; private set; }

        public LinkedList(Node headNode)
        {
            HeadNode = headNode;
        }
    }
}
