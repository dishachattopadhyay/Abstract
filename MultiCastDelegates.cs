using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{
    public delegate void TestDelegate(double width,double height);
    public class MultiCastDelegates
    {
    public class Rectangle
    {
        public void GetArea(double width,double height)
        {
            System.Console.WriteLine("Area is "+ width*height);
        }

        public void GetPerimeter(double height, double width)
        {
            System.Console.WriteLine("Perimeter is "+ 2*(width*height));
        } 

        // public int GetMult(int width,int height)
        // {
        //     //System.Console.WriteLine("Area is "+ width*height);
        //     return (width*height);
        // }
    }
    static void Main(string[] args)
    {
         //creating an obj of the class
        Rectangle obj1 = new Rectangle();

        //creating an object of the delegate
        TestDelegate test = new TestDelegate(obj1.GetArea); 
        //obj1.invoke(23,3.33);
        test(12.34,8.65);
        test.Invoke(5,6);

        //creating multicast delegate
        test += obj1.GetPerimeter;

        test(12,2);

        //test+= obj1.GetMult;


        
        


    }
}
}