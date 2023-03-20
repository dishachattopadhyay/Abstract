using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Abstract Class:
// 1. Can't be initialize, instantiated, static
// 2. Can contains abstract as well as non abstract methods 
// Abstract Methods:
// 1. Can't be static
// 2. Methods are implicitly virtual
// 3. Implemented in a inherited class using 'override' keyword

namespace firstprgrm
{
    public abstract class TestAbstract
    {
        public abstract void Shape();

        public void method()
        {
            System.Console.WriteLine("Non static method from abstract class");

        }
        
    }

    class Rectangle:TestAbstract
    {
        //its necessary to implement the abstract method
        public override void Shape()
        {
            System.Console.WriteLine("its a rectangle ");
        }
    }

    class Triangle : TestAbstract
    {
        public override void Shape()
        {
            System.Console.WriteLine("its a triangle ");
        }
    }

    public class TestClass
    {
        public static void Main()
        {
            Rectangle obj1 = new Rectangle();
            Triangle obj2 = new Triangle();

            obj1.Shape();
            obj1.method();

            obj2.Shape();
            obj2.method();
        }
    }
}