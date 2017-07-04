using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopDetector
{
    class Node
    {
        public int Data;
        public Node Next { get; set; }

        public Node(int data, Node next = null)
        {
            Data = data;
            Next = next;
        }

        public bool HasLoop()
        {
            Node slow = this;
            Node fast = this;
            do
            {
                slow = slow.Next;
                if (fast.Next != null)
                {
                    fast = fast.Next.Next;
                }
                else
                {
                    break;
                }
            } while (slow != fast && slow != null && fast != null);
            return slow == fast;
        }

        public List<Node> ListNodes()
        {
            List<Node> list = new List<Node>();
            if (!HasLoop())
            {
                list.Add(this);
                while (list.Last().Next != null)
                {
                    list.Add(list.Last().Next);
                }
            }
            return list;
        }
    }
}
