using System;
namespace random{
    class random{
        public static void Main(String [] args){
            var random = new Random();
            for (var i=0;i<=10;i++)
            {

                Console.WriteLine(random.Next()); //here we can create 10 random nums
                Console.WriteLine(random.Next(1,10)); //here we can limit the uper and lower bound

            }
            for (var i=0;i<=15;i++){
                Console.Write((char)random.Next(1,15));
                Console.WriteLine();
            }
            for (var i=0;i<=15;i++){
                Console.Write((char)random.Next(97,122));
            }

        }
    }
}
