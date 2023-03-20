using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{
    public class ListExample
    {
        public static void Main (string[] args)
        {
            List<int> hi = new List<int>();
            hi.Add(10); hi.Add(20); hi.Add(30); hi.Add(40);

            foreach( object obj in hi)
             System.Console.WriteLine(obj);
             System.Console.WriteLine();

            hi.Insert(2,76);   //void List<int>.Insert(int index, int item)
            hi.Insert(4,80);
            foreach( object obj in hi)
             System.Console.Write(obj +" ");
             System.Console.WriteLine();

            hi.Clear();
            hi.Insert(0,1);
            foreach( object obj in hi)
             System.Console.Write(obj +" ");





        }
    }
}