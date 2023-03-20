using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{
    public class LamdaExample
    {
        static void Main(string [] args)
        {
        Func<(int,int,int),(int,int,int)> Squre  = (a) => (a.Item1*a.Item1, a.Item2*a.Item2 , a.Item3*a.Item3);
        System.Console.WriteLine(Squre((1,2,3)));

        Action<(int,int,int)> cube = b => {System.Console.WriteLine((b.Item1*b.Item1 , b.Item2*b.Item2 , b.Item3*b.Item3));};
        cube((4,5,6));

        Predicate<string> chk = s => {  //single input parameter
            if (s.Length == 5)
                return false; //return type should always be bool
            return true;

        };
        System.Console.WriteLine(chk("Dishaaaaaaaa"));

        Predicate<string> length = a => { 
            if (a.Length>8)
               return false;
            return true;
        };
        System.Console.WriteLine(length("Abhishek"));
        }
        
    }
}