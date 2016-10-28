using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndCSharpMili
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee()
        {

        }
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
