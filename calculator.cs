using System;
namespace calculator{
    class calculator{
        public static void Main(String [] args)
        {
            // abc j = new abc();
            // j.hello();

            Int32 a,b,c;
            Console.Write("Enter first num ");
            a=Convert.ToInt32(Console.ReadLine());
            // Console.Write("Enter second num ");
            b=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Choose any Option ");
            Console.WriteLine("\t: + for Summation ");
            Console.WriteLine("\t: - for Substract ");
            Console.WriteLine("\t: * for Multiplication ");
            Console.WriteLine("\t: / for Division ");


            switch (Console.ReadLine())
            {
                case "+":
                  c= a+b;
                  Console.WriteLine("your result is {a} + {b} = s" + c);
                  break;
                case "-":
                  c= a-b;
                  Console.WriteLine("your result is {a} - {b} = " + c);
                  break;
                case "*":
                  c= a*b;
                  Console.WriteLine("your result is {a} * {b} = " + c);
                  break;
                case "/":
                  c= a/b;
                  Console.WriteLine("your result is {a} / {b} = " + c);
                  break;
            }

        }

    }
}
