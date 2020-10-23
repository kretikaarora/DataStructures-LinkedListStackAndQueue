using System;

namespace DataStructure_LinkedListStackAndQueue
{
    /// <summary>
    /// Program Class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Calling functions from Main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Operations on LinkedList Stack And Queue");
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(56);
            linkedListStack.Push(30);
            linkedListStack.Display();
        }
    }
}
