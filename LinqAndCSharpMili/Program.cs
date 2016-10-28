using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndCSharpMili
{
    class Program
    {
        static void Main(string[] args)
        {
            
            UseExtensionMethods();
            UseLambdaExpressions();
            ActionsAndFuncs();
            UseExpressions();

            

        }

        private static void UseExpressions()
        {
            Action PrintEmptyLine = () => Console.WriteLine();
            PrintEmptyLine();

            Action<int> PrintNumber = a => Console.WriteLine(a);
            PrintNumber(3);

            Action<int, int> PrintTwoParams = (a, b) => Console.WriteLine($"{a} {b}");
            PrintTwoParams(1, 2);

            Action<int, int> PrintTwoParamsMultiLine = (a, b) =>
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
            };                                                
            PrintTwoParamsMultiLine(3, 4);


            Func<DateTime> getTimme = () => DateTime.Now;
            Console.WriteLine(getTimme);

            Func<int, long> getSquared = (x) => Math.BigMul(x, x);
            Console.WriteLine(getSquared(3));

            Expression<Func<int, int, int>> getProduct = (x, y) => x * y;
            Console.WriteLine(getProduct.Compile());

            Func< int, int, int> compiledGetProduct = getProduct.Compile();
            Console.WriteLine(compiledGetProduct(5,15));

        }

        private static void ActionsAndFuncs()
        {
            //-----------------Actions!! They never return a value, always a void----------------//
            Action PrintEmptyLine = () => Console.WriteLine(); //If there is no parameter to the lambdaexpression then you keep the brackets empty.
            PrintEmptyLine();

            Action<int> PrintNumber = a => Console.WriteLine(a);
            PrintNumber(3);

            Action<int, int> PrintTwoParams = (a, b) => Console.WriteLine($"{a} {b}");
            PrintTwoParams(1, 2);

            Action<int, int> PrintTwoParamsMultiLine = (a, b) =>// This is how you do it multiline!!! :D Fucking awesome yo!!
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
            };                                                 // you need to use the curly braces when using muttiple lines of code in a lambda expression.
            PrintTwoParamsMultiLine(3, 4);

            //--------------------Funcs always return something----------------------------//

            Func<DateTime> getTimme = () => DateTime.Now;
            Console.WriteLine(getTimme);

            Func<int, long> getSquared = (x) => Math.BigMul(x, x);
            Console.WriteLine(getSquared(3));

            Func<int, int, int> getProduct = (x, y) => x * y;
            Console.WriteLine(getProduct(5,15));

        }

        private static void UseExtensionMethods()
        {
            string zipCode = "678992";

            bool result1 = StringExtensions.IsValidPostalCode(zipCode);

            bool result2 = zipCode.IsValidPostalCode(); //This is an extension method.            
        }

        private static void UseLambdaExpressions()
        {
            Employee[] employees = new Employee[]
            {
               new Employee {Id=1,Name="Scott" },
               new Employee {Id =2, Name = "Poonam" }
            };
            //Employee scott = Array.Find(employees, IsNameScott);

            //Employee scott = Array.Find(employees,
            //        delegate (Employee e)
            //        {
            //            return e.Name == "Scott";
            //        }
            //    );

            //Employee scott = Array.Find(employees,
            //        delegate (e)
            //        {
            //            return e.Name == "Scott";
            //        }
            //    )

            //Employee scott = Array.Find(employees,
            //        (e) =>
            //        {
            //            return e.Name == "Scott";
            //        }
            //    );

            //Employee scott = Array.Find(employees,
            //        (e) => e.Name == "Scott"
            //        );

            //Employee scott = Array.Find(employees, (e) => e.Name == "Scott");

            //Employee scott = Array.Find(employees, e => e.Name == "Scott");

            employees.Where(e => e.Name == "Scott");
        }

        //private static bool IsNameScott(Employee obj)
        //{
        //    if (obj.Name == "Poonam")
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
