using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{
    public class Task
    {
        public static void Main()
        {
            System.Console.WriteLine("*** TASK ***");
            System.Console.WriteLine();
            var AnonymousArrayNew = new[]{ 8,45,12,67};
            //var length= AnonymousArrayNew.Length; 

             Array.Sort(AnonymousArrayNew);
                foreach(int i in AnonymousArrayNew)
                {System.Console.WriteLine(i);}
            


            
            // for(int i=0 ;i<length ;i++)
            // {
            //     System.Console.WriteLine(AnonymousArrayNew[i]);
            // }

            
            
        }
    }
}