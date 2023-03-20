using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;

namespace firstprgrm
{
    public class ResultNew
    {
        public static void Main()
        {
            dynamic Student_Db ;
            Student_Db = new ExpandoObject();
            System.Console.Write("Enter Name ");
            Student_Db.name= Console.ReadLine();
            System.Console.WriteLine();
            System.Console.Write("Enter Roll ");
            Student_Db.roll = Console.ReadLine();
            System.Console.WriteLine();
            System.Console.Write("Data Structure ");
            Student_Db.Sub1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine();
            System.Console.Write("C Sharp ");
            Student_Db.Sub2 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine();
            System.Console.Write("Html ");
            Student_Db.Sub3 = Convert.ToInt32(Console.ReadLine());

            int a= Student_Db.Sub1+Student_Db.Sub2+Student_Db.Sub3;
            
            ExpandoMethodNew(Student_Db,a);

        }
             static void ExpandoMethodNew(dynamic obj , int a)
            {
                System.Console.WriteLine("Output :> Name : {0} , Rolll No : {1}, Result : {2} " , obj.name, obj.roll,a);
            }




        
    }
}