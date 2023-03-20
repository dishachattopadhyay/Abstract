using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{
    public class Stack_Queue
    {
        public static void Main(string[] args)
        {
            //***stack*** 
            Stack<int> st = new Stack<int>();
            st.Push(6);
            st.Push(2);
            st.Push(9);
            st.Push(1);
            st.Push(5);
            st.Push(2);

            System.Console.WriteLine("Stack");
            //System.Console.WriteLine(st);
            foreach (var item in st)
            {
                System.Console.WriteLine("Value stored in stack " + item);
            }


            Stack<int> st1 = new Stack<int>();

            do
            {
                System.Console.WriteLine("Enter value for stack :");
                int val = Convert.ToInt32(Console.ReadLine());
                st1.Push(val);

                System.Console.WriteLine("Press <end> to exit");
            } while (Console.ReadKey().Key != ConsoleKey.End);

            foreach (var item in st1)
            {
                System.Console.WriteLine("Value stored in stack " + item);
            }


            Queue q = new Queue();

            // Adding elements in Queue Using Enqueue() method
            q.Enqueue("Disha");
            q.Enqueue(1);
            q.Enqueue(100);
            q.Enqueue(null);
            q.Enqueue(2.4);


            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            Queue<int> q1 = new Queue<int>();


            q1.Enqueue(2);
            q1.Enqueue(1);
            q1.Enqueue(100);
            q1.Enqueue(34);
            q1.Enqueue(24);


            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }

            //delete from front
            var dq = q1.Dequeue();
            System.Console.WriteLine("Element deleted" +dq);

            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }

            //*****Dictionary*****            
            Dictionary<string,string> dt = new Dictionary<string, string>();
            dt.Add("Name","Disha");
            dt.Add("Country","India");
            System.Console.WriteLine("***Dictionary***");
            do 
            {
                 System.Console.Write("Enter key: ");
                 var ky = Console.ReadLine()!;
                  System.Console.Write("Enter value: ");
                 var vl = Console.ReadLine()!;
                  dt.Add(ky,vl); 
                 
                  System.Console.WriteLine("Press <end> to exit: ");
                 } while (Console.ReadKey().Key != ConsoleKey.End);
                 foreach (var item in dt)
                 {
                      System.Console.WriteLine(item);
                     } 
                     foreach (var item in dt.Keys)
                     { 
                         System.Console.WriteLine(item + ":" + dt[item]); 
                        }
        }
    }
}