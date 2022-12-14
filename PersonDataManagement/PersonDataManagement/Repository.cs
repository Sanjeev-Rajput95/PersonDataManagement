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

        public void Retrieving_TopTwoRecords_ForAgeLessThanSixty(List<Person> objListOfPersonsInCity)
        {
            foreach (var person in objListOfPersonsInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine($"\nName: {person.Name} \nAge: {person.Age}");
            }
        }

        public void Retrieving_Records_ForAgeBetween13to18(List<Person> objListOfPersonsInCity)
        {
            if (objListOfPersonsInCity.Any(e => (e.Age >= 13 && e.Age < 19)))
            {
                Console.WriteLine("\nYes, we have some teenagers in this list");
            }
            else
            {
                Console.WriteLine("\nNo, we do not have any teenages in this list");
            }
        }

        public void AverageAge(List<Person> objListOfPersonsInCity)
        {
            double average = objListOfPersonsInCity.Average(e => e.Age);
            Console.WriteLine($"\nAverage age in the list: {average}");
        }

        public void SpecificName_PresentOrNot(List<Person> objListOfPersonsInCity, string nameSearch)
        {

            if (objListOfPersonsInCity.Any(e => e.Name == nameSearch))
            {
                Console.WriteLine($"\nYes, {nameSearch} exist in the list");
            }
            else
            {
                Console.WriteLine($"\nNo, {nameSearch} does not exist in the list");
            }
        }

        public void SkipAgeLessThanSixty(List<Person> objListOfPersonsInCity)
        {
            foreach (var person in objListOfPersonsInCity.FindAll(e => (e.Age >= 60)).ToList())
            {
                Console.WriteLine($"\nName: {person.Name} \nAge: {person.Age}");
            }
        }

        public void RemoveSpecificName(List<Person> objListOfPersonsInCity, string nameSearch)
        {
            var found = objListOfPersonsInCity.Find(e => e.Name == nameSearch);
            if (found != null)
            {
                objListOfPersonsInCity.Remove(found);
                Console.WriteLine($"\n{nameSearch} removed successfully from the list");
            }
            else
            {
                Console.WriteLine($"\n{nameSearch} does not exist in the list");
            }
        }
    }
}
