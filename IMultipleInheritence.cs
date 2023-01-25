using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{
    public interface Interface1
    {
        void print();

        void show();
    }
    public interface Interface2
    {
        void print();

        void show();

    }

    public class Test: Interface1,Interface2
    {

        public void print()
            {
                System.Console.WriteLine("interface method implemented in child class");
            }

        void Interface1.show()
        {
            System.Console.WriteLine("interface 1");
        }

        void Interface2.show()
        {
            System.Console.WriteLine("interface 2");
        }
        public static void Main(String[] args)
        {
            Test obj = new Test();
            obj.print();

            Interface1 i1 = obj;
            i1.show();


            Interface2 i2 = obj;
            i2.show();

            

            

        }
    }
}