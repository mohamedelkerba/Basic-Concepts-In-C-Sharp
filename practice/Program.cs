using System;

namespace practice 
{
    class Program
    {
        static void Main(string[] args)
        {
         Date d1 = new Date(01,01,2004);
         Console.WriteLine(d1.GetDate());
        Employee emp1 = Employee.Create(1000, "Mohamed", "Flutter");

        }
    }

    public class Date
    {                                                  //0 , 1, 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 , 10 , 11 , 12     
        private static readonly int[] daysToMonth365 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] daysToMonth366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private readonly int year=01;
        private readonly int month=01;
        private readonly int day = 01;

        public Date(int day, int month, int year)
        {
            var isLeap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
            if(year>=1 && year <=9999 && month>=1 && month <= 12)
            {
                int[] days = isLeap? daysToMonth365 : daysToMonth366;
                if( day>=1 && day <= days[month])
                {
                    this.day = day;
                    this.month = month;
                    this.year = year;
                }
            }
           
        }

        public Date( int year) : this(01,01,year){}
        public Date(int month, int year) : this(01, month, year) { }


        public string GetDate(){
            return $"{this.day.ToString().PadLeft(2,'0')} /{this.month.ToString().PadLeft(2, '0')} /{this.year.ToString().PadLeft(2, '0')}";
        }

    }


    public  class Employee
    {
        // to dealing with prtivate construcor
        public static Employee Create ( int id , string name , string job)
        {
            return new Employee(id, name, job); 
        }
        private Employee() {}
        private Employee(int id , string name , string job)
        {
            this.id = id;
            this.name = name;
            this.job = job;                
        }


        public int id;
        public string name;
        public string job;
    }
}
