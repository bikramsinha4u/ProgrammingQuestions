using System;
using System.Collections.Generic;

namespace LinkedList
{
    class LinkedList<T>
    {
        public Node<T> Head;

        public static LinkedList<T> CreateLinkedList(List<T> input)
        {
            Node<T> first = new Node<T>(input[0]);
            Node<T> second = new Node<T>(input[1]);
            Node<T> third = new Node<T>(input[2]);

            LinkedList<T> linkedList = new LinkedList<T>();
            linkedList.Head = first;
            linkedList.Head.Next = second;
            second.Next = third;

            return linkedList;
        }

        public static void PrintLinkedList(LinkedList<T> inputList)
        {
            Node<T> n = inputList.Head;

            while (n != null)
            {
                Console.Write($"{n.Data}->");
                n = n.Next;
            }
            DeleteLastCharacterFromConsole();
            DeleteLastCharacterFromConsole();
        }

        #region Utility
        static void DeleteLastCharacterFromConsole()
        {
            Console.Write("\x1B[1D"); // Move the cursor one unit to the left
            Console.Write("\x1B[1P"); // Delete the character
        }
        #endregion
    }
}
