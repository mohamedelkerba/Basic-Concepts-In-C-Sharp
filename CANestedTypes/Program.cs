using System;
namespace CANestedTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee employee = new Employee();
			Console.WriteLine(employee.EmployeeInsurance.CompanyName);
			Console.ReadKey();
		}
	}

	class Employee
	{
        public int Id { get; set; }
        public string Name { get; set; }

		public Insurance EmployeeInsurance { get; set; }
        public Employee()
        {
			EmployeeInsurance = new Insurance {
				PolicyId = -1,
               CompanyName = "N/A"
			};
        }

        public  class Insurance
        {
            public int PolicyId { get; set; }
            public string CompanyName { get; set; }
        }

    }
	


	class Department
	{
		public int Id {get; set; } 
		public string Name { get; set; }	
	}
	







	class A
	{
		private int x;
		class B
		{
			void method() { 
					A a = new A ();
					a.x = 1;
			}
		} 
	}
	
}