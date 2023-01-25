using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{
    public class FeetToCm
    {
        public static void Main(String [] args)
        {
            System.Console.WriteLine("Enter : ");
            double feet = Convert.ToInt32(Console.ReadLine());
            //1 inch = 2.54cm
            //1 feet = 12 inch
            var res = feet * 30.48;
            System.Console.WriteLine("result "+res+"cm");
        }
    }
}