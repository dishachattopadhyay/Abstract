using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;

namespace firstprgrm
{
    public class AnonymousType
    {
        public static void Main(string [] args)
        {

            //Anonymous types do override the ToString method,
            // concatenating the name and ToString output 
            //of every property surrounded by curly braces.


            var v = new { Title = "Hello", Age = 24 };

            Console.WriteLine(v.ToString());

            var v1 = new { Amount = 108, Message = "Hello" };

            // Rest the mouse pointer over v.Amount and v.Message in the following
            // statement to verify that their inferred types are int and string.
            Console.WriteLine(v1.Amount + v1.Message);

            //Anonymous types support non-destructive mutation in the form of with expressions. 
            //This enables you to create a new instance of an anonymous type where
            // one or more properties have new values:



            var apple = new { Item = "apples", Price = 1.35 };

            var onSale = apple with { Price = 0.79 };
            Console.WriteLine(apple);
            Console.WriteLine(onSale);

            //creating an anonynous type
            var database = new {name = "Disha" , Location = "Kolkata" , Stipen = 18710};
            // creating anoter instance of database
            var db1 = database with {name = "Asima" };
            var db2 = db1 with {Stipen=50000};
            
            System.Console.WriteLine(database);
            System.Console.WriteLine(db1);
            System.Console.WriteLine(db2.Stipen);
            System.Console.WriteLine(db2);


            //creating nested anonymous type
            var nested = new { name = "Disha", Address = new {Current_Address = "SaltLake" , Parmanent_Address = "Barasat"} };
            System.Console.WriteLine(nested);
            System.Console.WriteLine(nested.Address.Parmanent_Address);

            //Anonymous Array
            System.Console.WriteLine("***** Anonymous Array *****");
            var AnonymousArray = new[]{
                new {name = "Ram" , Age = 40},
                new {name = "Shyam" , Age = 45},
                new {name = "Jadu" , Age = 49}

            };

            foreach(var item in AnonymousArray)
            {
                System.Console.Write(item.name);
                System.Console.Write(",");
                System.Console.WriteLine(item.Age);
            }
            
            System.Console.WriteLine("*** TASK ***");
            System.Console.WriteLine();
            var AnonymousArrayNew = new[]{ 8,45,12,67};
            Array.Sort(AnonymousArrayNew);
            System.Console.WriteLine();
            
        

            //Dynamic Object
            System.Console.WriteLine();
            System.Console.WriteLine("****** Dynamic Object ******");
            //Dynamic 
            dynamic d = 1; //dynamic is ref type
            var testSum = d + 3; //var is value type <faster>
            // Rest the mouse pointer over testSum in the following statement.
            System.Console.WriteLine(testSum);

            dynamic d1 = 7;
            dynamic d2 = "a string";
            dynamic d3 = System.DateTime.Today;
            
            //conversion
            int i = d1;
            string str = d2;
            DateTime dt = d3;
            

            System.Console.WriteLine(i);


            //Expando Object
            System.Console.WriteLine("****Exapndo Object*****");
            dynamic sample_Object = new ExpandoObject(); //sample_Object is an instance of the dynamic class expando object
            sample_Object.height = "6 feet";
            sample_Object.weight = 60;
            
            System.Console.WriteLine(sample_Object.height);
            System.Console.WriteLine(sample_Object.height.GetType());

            System.Console.WriteLine(sample_Object.weight);
            System.Console.WriteLine(sample_Object.weight.GetType());


            //passing expando object as parameter
            System.Console.WriteLine("*****passing expando object as parameter*****");
            dynamic newObject, objectNew ;
            newObject = new ExpandoObject();
            newObject.Name = "Disha";
            newObject.Surname = "Chattopadhyay";

            objectNew = new ExpandoObject();
            objectNew.Address="kolkata";
            objectNew.Mobile = 987654321;

             ExpandoMethod(newObject);
             ExpandoMethod1(objectNew);

        }
             static void ExpandoMethod(dynamic obj)
            {
                System.Console.WriteLine("Output :> {0} , {1} " , obj.Name, obj.Surname);
            }

             private static void ExpandoMethod1(dynamic obj)
            {
                System.Console.WriteLine("Output :> {0} , {1} " , obj.Address, obj.Mobile);
            }



            


            



        
    }
}