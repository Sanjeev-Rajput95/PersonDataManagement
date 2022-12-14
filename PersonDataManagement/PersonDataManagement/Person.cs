using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    public class Person
    {
        public string SSN, Name, Address;
        public int Age;

        public Person(string ssn, string name, string address, int age)
        {
            SSN = ssn;
            Name = name;
            Address = address;
            Age = age;
        }
    }
}
