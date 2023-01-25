using System;
namespace minmax{
    class maxmin{
        public static void Main(String[] args){
        Int32 num1,num2;
        Console.WriteLine("Enter two nums : ");
        num1=Convert.ToInt32(Console.ReadLine());
        num2=Convert.ToInt32(Console.ReadLine());
        if ( num1> num2){
            Console.WriteLine(num1+" is maximum");
        }
        else if(num2>num1){
            Console.WriteLine(num2 +" is maximum");
        }
        else {
             Console.WriteLine("Both are equal");
        }
           
        


        }  

    }
}
