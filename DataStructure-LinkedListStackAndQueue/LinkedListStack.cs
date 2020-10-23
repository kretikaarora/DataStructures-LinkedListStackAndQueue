// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedListStack.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kretika Arora"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DataStructure_LinkedListStackAndQueue
{
    /// <summary>
    /// Creating Stack using LinkedList
    /// </summary>
    class LinkedListStack
    {
        public Node top;

        /// <summary>
        /// Pushing the new data
        /// UC1
        /// </summary>
        /// <param name="newData"></param>
        public void Push(int newData)
        {
            ///creating a link between newnode and where top is pointing
            ///then pointing top towards the new node 
            ///new node is inserted on the top 
            Node newNode = new Node(newData);
            if(this.top!=null)
            {
                newNode.next = this.top;
            }
            this.top = newNode;
            Console.WriteLine("New node {0} is added", newNode.data);
        }

        /// <summary>
        /// Displaying the values in the stack
        /// </summary>
        public void Display()
        {
            ///checking if stack is not empty
            ///printing values till temp point towards null i.e. end of stack 
            Node temp = this.top;
            if(temp==null)
            {
                Console.WriteLine("no values to display , empty");
                return;
            }
            while(temp!=null)
            {
                Console.WriteLine("Value in the stack : "+temp.data);
                temp = temp.next;
            }
        }

        /// <summary>
        /// Displaying the top element
        /// UC2
        /// </summary>
        public void Peek()
        {
            ///Checking if top element is null
            ///otherwise printing the top element
            if(this.top==null)
            {
                Console.WriteLine("no element present to Peek");
                return;
            }
            Console.WriteLine("The element after Peeking is "+ this.top.data);
        }

        /// <summary>
        /// Displaying and Deleting the top element
        /// UC2
        /// </summary>
        public void Pop()
        {
            ///Checking if top element is null
            ///otherwise printing the top element and deleting it also
            if (this.top == null)
            {
                Console.WriteLine("no element present to Pop");
                return;
            }
            Console.WriteLine("The element poped is " + this.top.data);
            this.top = this.top.next;         
        }
    }
}
