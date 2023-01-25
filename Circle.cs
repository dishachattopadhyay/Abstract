using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{
    public class Circle
    {
        public static void Main(String[] args)
        {
            var pi = 3.14f;
            System.Console.WriteLine("Enter radius ");
            var r = Convert.ToInt32(Console.ReadLine());

            var area = pi * r * r;
            System.Console.WriteLine("Area is "+ area);
        }
    }
}