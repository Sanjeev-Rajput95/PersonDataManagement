namespace PersonDataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t=========== WELCOME TO PERSON DATA MANAGEMENT =============");

            List<Person> objListOfPersonsInCity = new List<Person>();
            Repository objRep = new Repository();
            objRep.AddRecords(objListOfPersonsInCity);
        }
    }
}