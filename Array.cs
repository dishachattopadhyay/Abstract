using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{
    public class ArrayNew
    {
        static void Main(string[] args)
        {

            //array with user input
            int[] arr = new int[4];
            //x=arr.length;
            for (int y = 0; y < arr.Length; y++)
            {
                System.Console.WriteLine("enter values ");
                arr[y] = Convert.ToInt32(Console.ReadLine());
            }
            System.Console.WriteLine("user input arr");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            System.Console.WriteLine();
            //sort     
            Array.Sort(arr);
            foreach(int i in arr){
                System.Console.WriteLine(i);
            }
            
            //sum
            int sum = arr.Sum();
            System.Console.WriteLine("Sum is "+sum);
            
            //duplicate
            var dup = arr.Count();
            System.Console.WriteLine("count "+ dup);

            //

            


            // Array.Reverse(arr);
            // for(var i=0; i< arr.Length; i++)
            // {
            //     System.Console.Write(arr[i] +" |");
            // }


            // var arr2 = new[] {3,4,5,6,7,8,9}; //whenever we use var why we cannot declare its values dynamically?

            // //length 
            // System.Console.WriteLine("first arry "+arr);
            // int length = arr.Length;
            // System.Console.WriteLine("Length of array "+length);
            // //IndexOf
            // var index= Array.IndexOf(arr,6);
            // System.Console.WriteLine( "Index of 6 "+ index);
            // var i2 = Array.IndexOf(arr2,5);
            // System.Console.WriteLine("index of 5 in arr2 "+ i2);
            // //clear()
            // Array.Clear(arr2,0,2); //(array name, startting index number , end index number)
            // System.Console.WriteLine("Effect of clear() ");
            // foreach (int a in arr2)
            // {
            //     System.Console.WriteLine(a);
            // }

            // //copy array
            // int[] another= new int[3];
            // int[] another2= new int[4];
            // try
            // {
            //     Array.Copy(arr2,another,4);
            //     System.Console.WriteLine("another array "+another);
            //     System.Console.WriteLine("effect of copy() ");
            //     foreach (var i in another) //initialize a item with var, then it will search between collection
            //     System.Console.WriteLine(i);



            // }
            // catch(Exception )
            // {
            //     System.Console.WriteLine("Error");
            // }

            // Array.Copy(arr2,another2,4);
            //  System.Console.WriteLine("another2 array "+another2);
            //  System.Console.WriteLine("effect of copy() ");
            //  foreach (var s in another2) //initialize a item with var, then it will search between collection
            //  System.Console.WriteLine(s);

        }
    }
}