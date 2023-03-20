using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{
    public class TupleExample
    {
        public static double Add(int x, float y , double z)
        {
            return x+y+z;
        }

        public static void Add2(int x, float y, double z)
        {
            System.Console.WriteLine(x+y+z);
        }

        public static bool CheckLength(string str)
        {
            if(str.Length >5)
              return true;
            return false;
        }

        static void Main()
        {
            Func<int,float,double,double> obj1= Add;
            double result = obj1.Invoke(100,34.5f,23.98);
            System.Console.WriteLine(result);

            
        }
    }
}