using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var createdList = LinkedList<int>.CreateLinkedList(LinkedListInput());
            LinkedList<int>.PrintLinkedList(createdList);

            Console.ReadKey();
        }

        #region Linked List
        static List<int> LinkedListInput()
        {
            List<int> inputList = new List<int> { 2, 5, 7 };
            //List<string> inputList = new List<string> { "two", "five", "seven" };

            return inputList;
        }
        #endregion        
    }
}
