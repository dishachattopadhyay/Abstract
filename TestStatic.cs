using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{

    //creating a static class
    public static class TestStatic
    {
        //static members
        public static int a=5,b=9;

        //static members
        public static void print()
        {
            System.Console.WriteLine("Static Class");
            System.Console.WriteLine(a+b);
        }

    }


   public class TestClass
   {
     public static void Main()
    {
        TestStatic.print();
    }
   }
}