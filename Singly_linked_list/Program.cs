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

            /*Menemukan lokasi node baru di dalam list*/
            Node previous, current;
            previous = START;
            current = START;

            while ((current != null) && (nim >= current.noMhs))
            {
                if (nim == current.noMhs)
                {
                    Console.WriteLine("\nNomer mahasiswa sama tidak diizinkan\n");
                    return;
                }
                previous = current;
                current = current.next;
            }

            /*Node baru akan ditempatkan diantara previous dan current*/
            nodeBaru.next = current;
            previous.next = nodeBaru;
        }

        /*Method untuk menghapus node tertentu di dalam list*/
        public bool delNode(int nim)
        {
            Node previous, current;
            previous = current = null;

            /*Cek apakah node yang dimaksud ada di dalam list atau tidak*/
            if (Search(nim, ref previous, ref current) == false)
                return false;
            previous.next = current.next;
            if (current == START)
                START = START.next;
            return true;
        }

        /*Method untuk menge-check apakah node yang dimaksud ada di dalam list*/
        public bool Search(int nim, ref Node previous, ref Node current)
        {
            previous = START;
            current = START;

            while ((current != null) && (nim != current.noMhs))
            {
                previous = current;
                current = current.next;
            }

            if (current == null)
                return (false);
            else
                return (true);
        }

        /*Method untuk Traverse/mengunjungi dan membaca isi list*/
        public void traverse()
        {
            if (ListEmpty())
                Console.WriteLine("\nList kosong.");
            else
            {
                Console.WriteLine("\nData di dalam list adalah: \n");
                Node curretntNode;
                for (curretntNode = START; curretntNode != null, curretntNode = curretntNode.next)
                    Console.Write(curretntNode.noMhs + " " + curretntNode.nama + "\n");
                Console.WriteLine();
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
