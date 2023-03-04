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
                Console.WriteLine("1.Add elements: \n 2.Display: \n 3.Add in Reverse \n 4.Append \n 5.Insert \n 6.RemoveFirstNode \n 7.RemoveLastNode \n 8.Find \n 9.Size");
            
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

                    case 3:
                        linkedList.AddReverse(56);
                        linkedList.AddReverse(30);
                        linkedList.AddReverse(70);
                        break;

                    case 4:
                        linkedList.Append(56);
                        linkedList.Append(30);
                        linkedList.Append(70);
                        break;

                    case 5:
                        Console.Write("Enter Data to insert: ");
                        int data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the posititon to insert: "); 
                        int position = Convert.ToInt32(Console.ReadLine());
                        linkedList.InsertPosition(position, data);
                        break;

                    case 6:
                        Console.WriteLine("The first element deleted");
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveFirstNode();
                        break;

                    case 7:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveLastNode();
                        break;

                    case 8:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Display();
                        linkedList.Find(30);
                        break;
                    case 9:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Display();
                        linkedList.Size();
                        break;
                    default:

                        Console.WriteLine("type correct value");
                        break;     
                }

            }
        }
    }
}