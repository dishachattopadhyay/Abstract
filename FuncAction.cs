using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{
    public class program
    {
        public Tuple<string, int, float, string> Details()
        {
            Tuple<string, int, float, string> Human = new Tuple<string, int, float, string>(Console.ReadLine()!, Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Console.ReadLine()!);
            return Human;
            //how to put cw for every input??
        }
    }
    public class FuncAction
    {


        static void Main(string[] args)
        {
            Func<int, int, int> Addition =(a,b) =>(a+b);  //Func has inputs and output parameters
            int result = Addition(10, 20);
            Console.WriteLine($"Addition = {result}");
            System.Console.WriteLine();

            Action<int, int> Multiplication = (x, y) => { System.Console.WriteLine(x * y); };  //Action has only input parameter
            Multiplication(34, 8);

            Func<int, int, double> sub = (w, r) => { return w - r; };     //sub is the method name .... w, r are the parameters
            System.Console.WriteLine();

            //tuple creation  (old process)
            System.Console.WriteLine("tuple creation  (old process)");
            Tuple<float, string> person = new Tuple<float, string>(34.5f, "Jhon");
            System.Console.WriteLine(person.Item2, person.Item1);
            System.Console.WriteLine();

            //tuple creation now
            //Tuple is also a child of object class
            System.Console.WriteLine("tuple creation now");
            (int, Double) tuple = (56, 5.7);
            System.Console.WriteLine($"Tuple :>{tuple}");

            System.Console.WriteLine();



            (double, float) tuple2 = (45.5, 45.9f);
            System.Console.WriteLine($"Tuple New :> {tuple2}");

            (int element, double elementNew) tuple3 = (56, 56.00);
            System.Console.WriteLine($"Tuple3 = {tuple3}");
            System.Console.WriteLine($" Tuple3 elementNew {tuple3.elementNew}, Tuple3 element {tuple3.element} ");

            //Lamda Expression
            Func<int, int> square = x => x * x;   //method name ,,, x input
            System.Console.WriteLine($" Func Squre{square(4)}");

            Action<int, int> division = (y, z) => System.Console.WriteLine($"Action Division {y % z}");
            division(15, 5);

            System.Console.WriteLine();
            System.Console.WriteLine(" :: ");
            //Method calling
            program p = new program();
            Tuple<string, int, float, string> Person = p.Details();
            System.Console.WriteLine("Name {0} , Age {1} , Height {2} , Address {3} ", Person.Item1, Person.Item2, Person.Item3, Person.Item4);


            // Normal Lamda Expression
            List<int> numbers = new List<int>() {36, 71, 12,
                             15, 29, 18, 27, 17, 9, 34};
            Console.Write("The list : ");
            foreach (var value in numbers)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            var mul = numbers.Select(x => x * x);
            System.Console.Write("Squre ");
            foreach (var item in mul)
            {
                System.Console.Write(" {0}", item);
            }
            System.Console.WriteLine();

            Func<(int, int), (int, int)> swap = (a) => (a.Item2, a.Item1);
            System.Console.WriteLine(swap((9, 1)));

            System.Console.WriteLine();
            System.Console.WriteLine();
            (double, int) t = (4.5, 3);
            Console.WriteLine(t.ToString());
            Console.WriteLine($"Hash code of {t} is {t.GetHashCode()}.");

            var t3 = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26);
            Console.WriteLine(t3.Item26);
            
            }




    }

}