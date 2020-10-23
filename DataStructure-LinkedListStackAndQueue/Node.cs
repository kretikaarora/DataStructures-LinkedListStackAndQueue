using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure_LinkedListStackAndQueue
{
    /// <summary>
    /// Creating a Node 
    /// </summary>
    class Node
    {
        public int data;
        public Node next;

        /// <summary>
        /// Creating a parameterised Constructor
        /// </summary>
        /// <param name="data"></param>
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
