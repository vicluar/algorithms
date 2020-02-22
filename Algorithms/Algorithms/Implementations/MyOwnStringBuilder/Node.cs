using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Implementations.MyOwnStringBuilder
{
    public class Node
    {
        public string Data { get; private set; }
        public Node Next { get; private set; }

        public Node(string data)
        {
            Data = data;
        }

        public void AddNextNode(Node nextNode)
        {
            Next = nextNode;
        }
    }
}
