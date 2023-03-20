using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{
    public class HashExample
    {
        public static void Main(string [] args)
        {
            Hashtable h = new Hashtable();
            h.Add("Id :" , 01); //void Hashtable.Add(object key, object? value)
            h.Add("Name :", "Disha");
            h.Add("Address :", "Barasat");
            h.Add("MgrId :", 1010);
            h.Add("Email: ","abc@yxz.com");

            foreach(object obj in h.Keys)
             System.Console.WriteLine(obj);

            System.Console.WriteLine();

            System.Console.WriteLine();

            foreach(object obj in h.Values)
             System.Console.WriteLine(obj);

            System.Console.WriteLine();

            foreach(object obj in h.Keys)
             System.Console.WriteLine(obj +":"+ h[obj]);

            System.Console.WriteLine();

            System.Console.WriteLine();
            System.Console.WriteLine("Disha".GetHashCode());

            System.Console.WriteLine("Remove");
            System.Console.WriteLine();
            h.Remove("MgrId :"); //void Hashtable.Remove(object key)
            foreach(object obj in h.Keys)
             System.Console.WriteLine(obj +" : "+ h[obj]);



            h.Clear();//this will return null
            System.Console.WriteLine();
            h.Add("New " , "Hello World !! ");
            foreach(object obj in h.Keys)
             System.Console.WriteLine(obj +" : "+ h[obj]);


            //user input
            System.Console.WriteLine("How many data you want to enter :> ");
            int a = Convert.ToInt32(Console.ReadLine());
            Hashtable w = new Hashtable();
            for(var i = 0; i<a ; i++){
                System.Console.WriteLine("Enter Key :  ");
                var k =Console.ReadLine() ;
                
                System.Console.WriteLine("Enter Value : "); 
                var v = Console.ReadLine();
                w.Add(k,v);
                
            }

            foreach(object obj in w.Keys)
             System.Console.WriteLine(obj +":"+ w[obj]);


        
        } 

    }
}