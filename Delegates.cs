using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{

    public delegate void newdelegates(int a, int b);

    public class Delegates
    {
         public void  add(int x , int y) //creating methods
         {
            System.Console.WriteLine($"Addition {x+y}");  //by using $ can pass values via parameters
         }

         public static void Multiplication(int r , int u)
         {
            //return r*u; needs to be void type
            System.Console.WriteLine($" Multiplication {r*u}");
         }

          public static void Sub(int x, int y) => Console.WriteLine($"Subtraction: {x - y}");  //lamda 
         public static void Main(String[] args)
         {
            //creating an object of delegates 
            //newdelegates del = new newdelegates(add); //An object reference is required for the non-static field, method, or property 'Delegates.add(int, int)'
            //class obj
            Delegates d = new Delegates();

            //creating object of delegates
            newdelegates del = new newdelegates(d.add); 
            //while calling a nonstatic method via delegates you have to create an objeect of that class which holds the method then delegates(obj.methodname) 
            del(34,87);

        
            del+=Sub; //multicasting delegates

            del(20,34);

            newdelegates del2 = new newdelegates(Multiplication);
            del2(9,8);



 
         }
    }
}