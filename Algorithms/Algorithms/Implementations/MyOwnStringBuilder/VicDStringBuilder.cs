using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Implementations.MyOwnStringBuilder
{
    public class VicDStringBuilder
    {
        private LinkedList _linkedList;

        public VicDStringBuilder()
        {
        }

        public void Append(string text)
        {
            var node = new Node(text);

            if (_linkedList != null)
                _linkedList.Append(node);
            else
                _linkedList = new LinkedList(node);
        }

        public override string ToString()
        {
            return _linkedList.GetAllNodeData();
        }
    }
}
