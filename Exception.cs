using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{
    public class Exception
    {
        public static void Main(string[] args)
        {
            try
            {
            // System.Console.WriteLine("Enter limit ");
            // int a = Convert.ToInt32(Console.ReadLine());
            // System.Console.WriteLine(a);

            System.Console.WriteLine();
            int[] arr = new int[5]{1,2,3,4,5};
            System.Console.Write("Enter a value for index: ");
            int ind = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(arr[ind]);
            // System.Console.WriteLine("Enter elements ");
            // for(int i=0; i<=a; i++)
            // {
            //     arr[i]=Convert.ToInt32(Console.ReadLine());
            // } 
            }
             catch(FormatException ex) //creating object of format exception
             {
                 System.Console.WriteLine(ex.Message);
             }

             catch(IndexOutOfRangeException ex)
             {
                System.Console.WriteLine(ex.Message);
             }

             

             finally
             {
                System.Console.WriteLine("finaly block");
             }
        //The InnerException is a property of an exception. When there are series of exceptions, 
        //the most current exception can obtain the prior exception in the InnerException property.

        //Let us say we have an exception inside a try block throwing an ArgumentException and the catch clause catches 
        //it and writes it to a file. However, if the file path is not found, FileNotFoundException is thrown.
        // Let's say that the outside try block catches this exception, but how about the actual ArgumentException that was thrown?
        // Is it lost? No, the InnerException property contains the actual exception. This is the reason for the existence of an
        // InnerException property for any exception.



        }
    }
}