using System;
namespace copy{
    class CopyConDemo{
        int x;
        public CopyConDemo(int a){   //parameterized
            a=x;
        }
        public CopyConDemo(CopyConDemo obj){     //copy


        }
        public void Display(){
            System.Console.WriteLine("value of x " + x);
        }
        static void Main(){
            CopyConDemo cd1 = new CopyConDemo(20);
            cd1.Display();
            Console.ReadLine();
        }
    }
}