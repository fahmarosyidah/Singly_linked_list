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

        /*Method untuk menambahkan sebuah Node ke dalam list*/
        public void addNode()
        {
            int nim;
            string nm;
            Console.Write("\nMasukkan nomer Mahasiswa: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nMasukkan nama Mahasiswa: ");
            nm = Console.ReadLine();
            Node nodeBaru = new Node();
            nodeBaru.noMhs = nim;
            nodeBaru.nama = nm;

            /*Node ditambahkan sebagai node*/
            if (START == null || nim <= START.noMhs)
            {
                if ((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nNomer mahasiswa sama tidak diizinkan\n");
                    return;
                }
                nodeBaru.next = START;
                START = nodeBaru;
                return;
            }
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
