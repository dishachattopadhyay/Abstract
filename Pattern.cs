using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstprgrm
{
    public class Pattern
    {
        public static void Main(String[] args)
        {   
            for (int j=1;j<=3;j++){
            
            for( int i=1;i<=10;i++)
            {
                if(i==5 || i==6){
                    continue;
                }
                    System.Console.Write(i+" ");
            }
            System.Console.WriteLine();
            }

            for(int a=1;a<=2;a++)
            {
            for(int b=10;b>=1;b--)
            {
                System.Console.Write(b+" ");
            }
            System.Console.WriteLine();
            }

            for(int k=10;k>=3;k--)
            {
                System.Console.Write(k+" ");
            }
            System.Console.WriteLine();

            for(int y=10;y>=1;y--)
            {
                System.Console.Write(y+" ");
            }
            System.Console.WriteLine();

            for(int e=1;e<=10;e++)
            {
                if(e==8)
                {continue;}
                System.Console.Write(e+" ");
            }

    }
    }
}