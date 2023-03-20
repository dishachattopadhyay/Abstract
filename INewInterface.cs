using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Interface:
// 1. In C# 8.0 we can have concrete method inside Interface
// 2. Security: Hide some feature or information
// 3. Multiple inheritence
namespace firstprgrm
{

    //scope of an interface is by default public and abstract
     interface NewInterface1
    {
        void Add(int a , int b);
        
    }
 // here we have not implemented this interface and also give a body of the method still not giving any error
    interface NewInterface2
    {
        void Sub(int a , int b)
        {
           System.Console.WriteLine("hi");
        }
    }

    //inheriting interface 
    interface NewInterface3 : NewInterface1 , NewInterface2// this contained two methods
    {
        void Mul(int a , int b);
    }

    //creating class , (by default private and non abstract)
    public class Implement : NewInterface3 // now we have to inplement those methods here without any fail
    {
        public void Mul(int a , int b)
        {
            System.Console.WriteLine(a*b);
        }

         //another way of implementation
        // void NewInterface1Add(int a , int b)
        // {

        // }

        //multiple inheritence is not possible in class but possible in interface
        //because consumtion cause ambiguity but implementation doesnot

        public void Add(int a , int b)
        {
            System.Console.WriteLine(a+b);

        }

        public static void Main(string[] args)
        {
            Implement obj1 = new Implement();
            Implement obj2 = new Implement();
            obj1.Add(13,87);
            obj1.Mul(2,3); 

            //creating a reference of the interface
            NewInterface1 a= obj2;
            obj2.Add(7,878);
        }

    }
    
    
}