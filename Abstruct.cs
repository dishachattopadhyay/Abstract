using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{
    class Abstruct
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();

            d.sound();
            d.Tail();
        }
    }
    abstract class Animal
    {
        public abstract void sound(); // abs method doesn't contain a body

        public void Tail() //regular method
        {
            System.Console.WriteLine("has tail");
        }

    }

    class Dog : Animal
    {
        public override void sound()  //using override 
        {
            System.Console.WriteLine(" wee wee");
        }
    }

    
}
