using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            while (true)
            {
                Console.WriteLine("Enter the Number:");
                Console.WriteLine("1.Add elements: \n 2.Display:");
                
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        break;
                    case 2:
                        linkedList.Display();
                        break;
                    default:
                        Console.WriteLine("type correct value");
                        break;
                }

            }
        }
    }
}