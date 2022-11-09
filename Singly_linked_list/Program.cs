using System;

namespace Singly_linked_list
{
    class Node
    {
        public int noMhs;
        public string nama;
        public Node next;
    }

    class List
    {
        Node START;

        public List()
        {
            START = null;
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
