using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Static:
// 1. cannot be instantiated
// 2. We can only have public modifier
// 3. Can have static constructor but cannot have modifier for constructor
// 4. Static class is sealed by default so it can't be inherited
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


   public class TestClass1
   {
     public static void Main()
    {
        TestStatic.print();
    }
   }
}