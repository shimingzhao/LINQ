using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // test for the var
            var x = 1;
            //x = "hi";   // will not work because x is int data type
            Console.WriteLine(x + " " + x.GetType() + " " + " " + x.GetTypeCode());

            // test the "foreach"
            int[] num = new int[6] {1, 2, 3, 4, 5, 4};
            foreach(int element in num)
            {
                if (element > 3)
                {
                    Console.WriteLine(element); // reading
                }
                
            }

            // test the "search"
            var searchNum = from element in num
                            where element > 3
                            orderby element descending
                            select element;

            Console.WriteLine(searchNum.GetType());

            foreach (int e in searchNum)
            {
                Console.WriteLine(e);
            }

            //foreach (int element in num)
            //{
            //    element = 100;
            //}

            // test the Emp class
            //Emp emp1 = new Emp("Yi", 4000);
            //Emp emp2 = new Emp("Mohammad Hossein", 5000);

            //Console.WriteLine(emp1);
            //Console.WriteLine(emp2);

            Emp[] empArray = {
                                 new Emp("Yi", 4000),
                                 new Emp("Mohammad Hossein", 5000),
                                 new Emp("Hero", 500),
                                 new Emp("AntiHero", 10000),
                                 new Emp("Wang", 500)
                             };

            var highSalaryEmp = from singleEmp in empArray
                                //where singleEmp.Salary < 3000
                                //orderby singleEmp.Name
                                orderby singleEmp.Salary descending
                                select singleEmp.Salary;
            Console.WriteLine("You have the distinct salary in the array");
            foreach (decimal element in highSalaryEmp.Distinct())
            {
                Console.WriteLine(element);
            }
        }
    }
}
