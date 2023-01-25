using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{
    public class MethodOverLoading
    {
        public int sum(int a)
        {
            System.Console.WriteLine(" first sum");
            return a;
        }

        public int sum(int a, int b)
        {
            System.Console.WriteLine(" seconf sum");
            return (a+b);
        }

        public int sum(int a, int b, int c)
        {
            System.Console.WriteLine("3rd sum ");
            return(a+b+c);
        }
    }

    public class TestOverload
        {
            public static void Main()
            {
                MethodOverLoading obj1 = new MethodOverLoading();
                obj1.sum(2);
                obj1.sum(3,4);
                obj1.sum(6,2,7);
            }
        }
    
}