using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    internal class LinkedList 
    {
        public Node head;
        public Node tail;

        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine($"\n{node.data} is added to the list.");
        }

        public void Display()
        {
            Node temp = this.head;
            if (head != null)
            {
                Console.WriteLine("\nItems in list are: ");
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
        public void AddReverse(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                node.next = temp;
                head = node;
            }
            Console.WriteLine($"{node.data} is now Head");
        }
        public void Append(int data)
        {
            Node node = new Node(data);
            if (head != null)
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine($"{node.data} is added after {temp.data}");
            }
            else { head = node; }
        }
        public void InsertPosition(int position, int data)
        {

            if (head != null && position > 0)//
            {
                Node node = new Node(data);
                if (position == 1)
                {
                    node.next = head;
                    this.head = node;
                }
                else
                {
                    Node temp = head;
                    for (int i = 1; i < position - 1; i++)
                    {
                        if (temp.next == null)
                        {
                            Console.WriteLine("Entered position is larger than linkedlists length \n Adding data at the last node.next");
                            break;
                        }
                        temp = temp.next;
                    }
                    node.next = temp.next;//null
                    temp.next = node;
                }
                Display();
            }
            else
            {
                Console.WriteLine("Enter Valid Position");
            }
        }
        public void RemoveFirstNode()
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is Empty");
            }
            else
            {
                this.head = this.head.next;
                Console.WriteLine("The first element is deleted");
            }
        }
        public void RemoveLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("lined list is empty");
            }
            if (head.next == null)
            {
                head = null;
            }
            else
            {
                Node laastNode = this.head;
                while (laastNode.next.next != null)
                {
                    laastNode = laastNode.next;
                }
                laastNode.next = null;
                Console.WriteLine("the last element is deleted");
            }
        }
        public void Find(int FindData)
        {
            int count = 0;
            Node tempNode = this.head;
            if (tempNode == null)
                Console.WriteLine("Linke list is empty");
            else
            {
                while (tempNode != null)
                {
                    if (tempNode.data.Equals(FindData))
                    {
                        count++;
                    }
                    tempNode = tempNode.next;
                }
            }
            if (count > 0)
                Console.WriteLine(FindData + " data found " + count + ": time ");
            else
                Console.WriteLine(" data not found\n");
        }
        public void Size()
        {
            int size = 0;
            Node tempNode = this.head;
            if (tempNode == null)
                Console.WriteLine("Linke list is empty");
            else
            {
                while (tempNode != null)
                {
                    tempNode = tempNode.next;
                    size++;
                }
                Console.WriteLine("Size :" + size);
            }
        }

    }
}


