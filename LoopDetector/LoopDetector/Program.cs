using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            Node a = new Node(1);
            Node b = new Node(2);
            Node c = new Node(3);
            Node d = new Node(4);
            Node e = new Node(5);
            Node f = new Node(6);
            Node g = new Node(7);
            Node h = new Node(8);
            Node i = new Node(9);
            a.Next = b;
            b.Next = c;
            c.Next = d;
            d.Next = e;
            e.Next = f;
            f.Next = g;
            g.Next = h;
            h.Next = i;
            i.Next = a;

            Console.WriteLine(a.ListNodes().Select(node => node.Data).ToArray());

            Console.WriteLine();
            Console.WriteLine(a.HasLoop());
            Console.ReadKey();
        }
    }
}
