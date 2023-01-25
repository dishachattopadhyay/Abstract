using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{
    public class Height
    {
        public static void Main(String[] args)
        {
            //inch
            System.Console.WriteLine("Enter your Height ");
            int h = Convert.ToInt32(Console.ReadLine());
            double i = h * 2.54;
            if(h<150){
                System.Console.WriteLine("Dwarf ");
            }
            else if( h>150 &&h<165){
                System.Console.WriteLine("Avg Height");

            }
            else if (h>165 && h<195){
                System.Console.WriteLine("Tall");
            }
            else
                System.Console.WriteLine("Abnormal Height");
            
        } 
        
    }
}