using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{
    public class SecondToDays
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter second ");
            int sec = Convert.ToInt32(Console.ReadLine());
            var d = sec/86400;
            sec = sec-(d*86400);
            int Hour = sec/3600;
            sec = sec - (Hour * 3600);
            int min = sec/60;
            sec = sec - (min*60);
            System.Console.WriteLine("{0} Days, {1} Hours, {2} Minutes, {3} seconds",d,Hour,min,sec);



        }
}}