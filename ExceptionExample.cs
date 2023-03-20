using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace firstprgrm
{
    public class DivideByfive : ApplicationException
        {
            public override string Message{
                get{
                    return "Can't divide by 5";
                }
            }
        }
    public class ExceptionExample
    {

        
        public static void Main(String[] args)
        {
            
            try
            {
                System.Console.WriteLine(" Division ");
                System.Console.WriteLine("Enter Data");
                int a = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Enter Data");
                int b = Convert.ToInt32(Console.ReadLine());

                

                var z= a/b;
                if(b%2>2)
                {
                    throw new firstprgrm.DivideByfive();
                }
                System.Console.WriteLine("Result : "+z);

            }
            // catch(DivideByfive df){
            //     System.Console.WriteLine(df.Message);
            // }

            catch(DivideByZeroException ex1)
            {
                System.Console.WriteLine(ex1.Message);
            }
            catch(FormatException ex)
            {
                System.Console.WriteLine("Can not put anything other than ineger");
                System.Console.WriteLine(ex.Message);
            }
            catch(OverflowException ex4)
            {
                System.Console.WriteLine(ex4.Message);
            }
            catch(System.Exception ex3 )
            {
                System.Console.WriteLine(ex3.Message);
            }
        
        }
    }
}