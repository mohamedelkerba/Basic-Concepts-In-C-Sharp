using CADelegate;
using System.Security.Cryptography.X509Certificates;

namespace CADelegate
{

    public delegate void RecDel(decimal width, decimal height);
    
      class Program
    {
       
        static void Main(string[] args)
        {
             var emps = new Employee[] {
                 new Employee {  Id = 1,Name = "Mohamed" , Gender = "M" , TotalSales = 50000m},
                 new Employee {  Id = 2,Name = "Hassan " , Gender = "M" , TotalSales = 600504m},
                 new Employee {  Id = 3,Name = "Salah  " , Gender = "M" , TotalSales = 54000m},
                 new Employee {  Id = 4,Name = "Zaki   " , Gender = "M" , TotalSales = 40000m},
                 new Employee {  Id = 5,Name = "Ibrahim" , Gender = "M" , TotalSales = 5400m},
                 new Employee {  Id = 6,Name = "3laa   " , Gender = "M" , TotalSales = 90000m},
                 new Employee {  Id = 7,Name = "Noor   " , Gender = "F" , TotalSales = 479852m},
                 new Employee {  Id = 8,Name = "Walaa  " , Gender = "F" , TotalSales = 15000m},
                 new Employee {  Id = 8,Name = "Lala   " , Gender = "M" , TotalSales = 29000m},
             };

             var report = new Report();                                   // lambda expression
             report.ProcessEmployee(emps, "Employees with Sales >= $60000+",( Employee e )=> e.TotalSales > 60000m );
                                                                                               // OR THIS STYLE ^         
            report.ProcessEmployee(emps, "Employees with Sales > $30000+ And Sales < $60000",  e => e.TotalSales > 30000m && e.TotalSales < 60000m);
             report.ProcessEmployee(emps, "Employees with Sales < $30000", e=>  e.TotalSales < 30000m);


           /* static bool IsGreaterThan60000(Employee e) => e.TotalSales >= 60000;
            static bool IsGreaterThan30000AndLessThan60000(Employee e) => e.TotalSales >= 60000;
            static bool IsGreaterThan30000(Employee e) => e.TotalSales >= 60000;
           */


            var helper = new Rectangle();
            RecDel del;
            del = helper.getArea;
            del += helper.getPerimeter;
            del(20,20);

            Console.ReadKey();
        }

    }

    // multicast Delegate 
    public class Rectangle
    {
        public void getArea(decimal width, decimal height) { 
        
            var result = width *height;
            Console.WriteLine($"Area : {result}");
        }

        public void getPerimeter(decimal width, decimal height) {

            var result = 2*( width + height);
            Console.WriteLine($"Perimeter : {result}");
        }
    }
};

