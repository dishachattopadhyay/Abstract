using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{
    public class AsyncExample
    {
        public static async void Method()
        {
            for (int i=0;i<5; i++)
            {
                System.Console.WriteLine(" first Method ");
                //await Task.Delay(3000);
            }
        }

        public static async void Method2()
        {
            for(int i=0;i<=10;i++)
            {
                System.Console.WriteLine(" Second Method ");
                //await Task.Delay(2000);
            }
        }

        static void Main(string[] args)
        {
            Method();
            Method2();
            Console.ReadKey();  //why we need to use this??
            System.Console.WriteLine(" End of Program ");
            //Console.ReadKey();
        }
    }
}