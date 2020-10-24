using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure_LinkedListStackAndQueue
{
   /// <summary>
   /// creating linkedlist queue
   /// </summary>   
    class LinkedListQueue
    {
        public Node head;

        /// <summary>
        /// Adding an element at the top
        /// UC3
        /// </summary>
        /// <param name="newData"></param>
        public void Enqueue(int newData)
        {
            ///queue element can be added from top and removed from bottom (like an actual queue)
            ///checking if head is null then making it point towards new node
            ///otherwise creating temp and iterating until it reaches top or null element
            ///then creating a new link between top element and new element
            Node newNode = new Node(newData);                    
            if(this.head==null)
            {
                this.head = newNode;             
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("Adding the element " + newNode.data);
        }

        /// <summary>
        /// Removing the first element
        /// UC4
        /// </summary>
        public void Dequeue()
        {
            ///checking if queue is empty
            ///otherwise removing the top element by shifting head to next element 
            ///breaking the link of first node 
            if (this.head == null)
            {
                Console.WriteLine("No element to remove , queue is empty");
                return;
            }
            Console.WriteLine("The element {0} is removed after Dequeue", this.head.data);
            this.head = this.head.next;
        }

        /// <summary>
        /// Displaying values in the LinkedListQueue
        /// </summary>
        public void Display()
        {
            ///Displaying every element by iterating temp till it is null
            Console.WriteLine("Display of Values in queue");
            if (this.head == null)
            {
                Console.WriteLine("No element to display , queue is empty");
                return;
            }
            Node temp = this.head;
            while(temp!=null)
            {
                Console.WriteLine("The value in the queue " + temp.data);
                temp = temp.next;              
            }
        }
    }
}
