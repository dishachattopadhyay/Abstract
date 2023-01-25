using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{
    public class RoundUpDown
    {
        public static void Main (String[] args)
        {
            System.Console.WriteLine("Input Num ");
            var input = Convert.ToInt32(Console.ReadLine());
            int M = input % 1000;

            if(M<500){
                System.Console.WriteLine("1000");

            }
            else if (M>=500){
                System.Console.WriteLine("2000");
            }
        }
    }
}