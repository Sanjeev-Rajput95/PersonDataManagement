using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    public class Repository
    {
        public void AddRecords(List<Person> objListOfPersonsInCity)
        {
            objListOfPersonsInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork, NY", 15));
            objListOfPersonsInCity.Add(new Person("203456877", "Sam", "13 Main Ct, Newyork, NY", 25));
            objListOfPersonsInCity.Add(new Person("203456878", "Elan", "14 Main Street, Newyork, NY", 35));
            objListOfPersonsInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork, NY", 45));
            objListOfPersonsInCity.Add(new Person("203456880", "Sue", "32 Cranbrook Rd, Newyork, NY", 55));
            objListOfPersonsInCity.Add(new Person("203456881", "Winston", "126 Province Ave, Newyork, NY", 65));
        }
    }
}
