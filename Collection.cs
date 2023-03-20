using System;
//using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace firstprgrm
{
    public class Collection
    {
        public static void Main(string [] args)
        {
            ArrayList a = new ArrayList();
            System.Console.WriteLine(a.Capacity);
            //Auto resizing
            a.Add(100);
            //capacity will increase *2
            System.Console.WriteLine(a.Capacity);
            a.Add(200);a.Add(378);a.Add(987);a.Add(542);
            a.Add("yt");
            System.Console.WriteLine(a.Capacity);

            System.Console.WriteLine(" ArrayList ");
            foreach(var item in a)
             System.Console.Write(item+" ");
             System.Console.WriteLine();

            // ArrayList<int> a1 = new ArrayList(); (ArrayList non generic)

            //inserting element in between 
            a.Insert(4,654); //void ArrayList.Insert(int index, object? value)
            System.Console.WriteLine(" ArrayList ");
            foreach(var item in a)
             System.Console.Write(item+" ");

            //Removing Element
            a.Remove(987);
            System.Console.WriteLine(" ArrayList ");
            foreach(var item in a)
             System.Console.Write(item+" ");
            System.Console.WriteLine();

            a.RemoveAt(0); //void ArrayList.RemoveAt(int index)
            System.Console.WriteLine(" ArrayList ");
            foreach(var item in a)
             System.Console.Write(item+" ");
            System.Console.WriteLine();

            System.Console.WriteLine("User defined data  :>");
            ArrayList arr = new ArrayList();

            
            System.Console.WriteLine("Enter the number of data you want to enter  ");
            var y = Convert.ToInt32(Console.ReadLine());
            
            for(int i=0; i<y;i++)
            {   System.Console.WriteLine("Enter Data  1st: ");
                arr.Add(Convert.ToInt32(Console.ReadLine()));
            }
            
            System.Console.WriteLine();
            foreach( object obj in arr)
             System.Console.Write(obj +" ");
             System.Console.WriteLine();

            ArrayList ab = new ArrayList();
            do{ 
                System.Console.WriteLine();
                System.Console.WriteLine("Enter Data ");
                 var Z = Convert.ToInt32(Console.ReadLine());
                 ab.Add(Z);

                 System.Console.Write("Press <END> to exit: ");
                //  var k = Console.ReadKey();

            }
            while (Console.ReadKey().Key!=ConsoleKey.End);
           
            System.Console.WriteLine();
            foreach( object obj in ab)
             System.Console.Write(obj +" ");
             System.Console.WriteLine();

        
           


            
        }
    }
}