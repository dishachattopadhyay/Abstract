using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{
    
    public partial class partial
    {
        //private variable

        private int a;
        private int b;

        public partial(int x, int y)
        {
            this.a=x;
            this.b=y;
        }
        
    }  

    public partial class partial
    {
        //mehod
        public void print()
        {
            System.Console.WriteLine("a= {0} , b={1} ",a,b);
        }
        
        // public partial()
        // {}

       

    }

    public class TestPartial 
    {
        public static void Main( string[] args)
        {
            partial obj = new partial(9,7);
            obj.print();
        } 
    }

    }
