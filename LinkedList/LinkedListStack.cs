using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedListStack
    {
        public Node top;
        public LinkedListStack()
        {
            this.top = null;
        }

        public void push(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
                this.top = node;
            Console.WriteLine(data);
        }
        public void Display()
        {
            Node temp = this.top;
            Console.WriteLine("Stack is ");
            while(temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
