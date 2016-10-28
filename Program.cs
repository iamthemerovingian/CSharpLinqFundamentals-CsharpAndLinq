using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqAndCSharp.Extensions;
using System.Linq.Expressions;

namespace LinqAndCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            UseExtensionMethods();
            UseLambdaExpression();
            ActionsAndFuncs();
            UseExpressions();
        }

        private static void UseExpressions()
        {
            Action printEmptyLine = () => Console.WriteLine();
            Action<int> printNumber = x => Console.WriteLine(x);
            Action<int, int> printTwoNumbers = (x, y) =>
                                   Console.WriteLine(String.Format("{0}\n{1}", x, y));

            Func<DateTime> getTime = () => DateTime.Now;
            Func<int, int> sqaure = x => x * x;
            
            
            Expression<Func<int, int, int>> multiply = (x, y) => x * y;


            printEmptyLine();
            printNumber(3);
            printTwoNumbers(5, 10);

            DateTime now = getTime();


            Func<int, int, int> mult = multiply.Compile();
            int z = mult(5, 15);
        }     
        
        private static void ActionsAndFuncs()
        {
            Action printEmptyLine = () => Console.WriteLine();
            Action<int> printNumber = x => Console.WriteLine(x);
            Action<int, int> printTwoNumbers = (x, y) =>
                                   Console.WriteLine(String.Format("{0}\n{1}", x, y));

            Func<DateTime> getTime = () => DateTime.Now;
            Func<int, int> sqaure = x => x * x;
            Func<int, int, int> multiply = (x, y) => x * y;


            printEmptyLine();
            printNumber(3);
            printTwoNumbers(5, 10);

            DateTime now = getTime();
            int z = multiply(5, 15);
        }

        private static void UseLambdaExpression()
        {
            Employee[] employees = new Employee[]
            {
                new Employee { ID=1, Name="Scott"},
                new Employee {ID = 2, Name="Poonam"}
            };

            //Employee scott = Array.Find(employees, FindScottPredicate);

            Employee scott = Array.Find(employees, e => e.Name == "Scott");

            Employee query1 =
               (from e in employees
                where e.Name == "Scott"
                orderby e.ID ascending
                select e).First();

             Employee query2 =
                employees.Where(e => e.Name == "Scott")
                         .OrderBy(e => e.ID)
                         .Select(e => e)
                         .First();

            
        }

        private static void UseExtensionMethods()
        {
            string zipCode = "21740";

            bool result = LinqAndCSharp.Extensions.StringExtensions.IsValidPostalCode(zipCode);

            bool result2 = zipCode.IsValidPostalCode();
        }

        static bool FindScottPredicate(Employee e)
        {
            return e.Name == "Scott";
        }
    }
}
