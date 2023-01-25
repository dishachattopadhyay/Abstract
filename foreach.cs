using System;
namespace foreachloop {
    class foreachloop {
        public static void Main(String[] args){
            string [] name = {"Disha",  "Chattopadhyay"};
            
            //for loop
            for(var i=0;i<=name.Length;i++){
                Console.WriteLine(name[i]+'-'+i);
                i = i+i;
                Console.WriteLine(name[i]+'-'+i);
            }
            
            //foreach loop
            // foreach ( var character in name){
            //     Console.WriteLine(character);
            //      character= character+"xyz";
            // }

        }


        //throw

    }
}

