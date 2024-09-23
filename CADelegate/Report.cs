using System;

namespace CADelegate
{
    public  class Report
    {
        public delegate bool IllegibleSales(Employee e); 

        public void ProcessEmployee(Employee[] employees, string title, IllegibleSales isIllegible ) {
            Console.WriteLine(title);
            Console.WriteLine("------------------------------------");
            foreach (var e in employees)
            {
                if (isIllegible(e))
                {
                    Console.WriteLine($" ID: {e.Id} | Name: {e.Name} | Gender: {e.Gender} | Total Sales: {e.TotalSales}");
                }

            }
            Console.WriteLine("\n \n");

        } 



    }
}
