using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Implementations.MyOwnStringBuilder
{
    public class LinkedList
    {
        public Node HeadNode { get; private set; }

        public LinkedList(Node headNode)
        {
            HeadNode = headNode;
        }

        public void Append(Node node)
        {
            var currentNode = HeadNode;

            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            currentNode.AddNextNode(node);
        }

        public string GetAllNodeData()
        {
            return IterateNodes(HeadNode);
        }

        private string IterateNodes(Node currentNode)
        {
            if (currentNode.Next != null)
                return currentNode.Data + IterateNodes(currentNode.Next);

            return currentNode.Data;
        }
    }
}
