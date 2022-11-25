using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work
{
    internal class Employee
    {
        internal string name;
        internal int number;
        internal string department;
        internal Employee(string name) 
        { 
            this.name = name;
        }
        internal Employee(string name, int number, string department)
        {
            this.name = name;
            this.number = number;
            this.department = department;
        }
    }
}
