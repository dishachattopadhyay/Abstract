using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{
    public class Greatest
    {
        public static void Main(string[] args)
        {
            int n1= 60;
            int n2 = 45;
            int n3 = 123;
            if (n1>n2){
                if(n1>n3){
                    System.Console.WriteLine(n1);
                }
                else {
                    System.Console.WriteLine(n3);
                }
            }
            else
            {
                if(n2>n3){
                    System.Console.WriteLine(n2);
                }
                else {
                    System.Console.WriteLine(n3);
                }
            }
            }
        }
    }
