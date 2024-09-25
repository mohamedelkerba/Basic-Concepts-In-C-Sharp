namespace CAEvents
{
    class Program // subcriber
    {
        static void Main(string[] args)
        {

            var stock = new Stock("Amazon");
            stock.Price = 100;
            stock.OnPriceChanged += Stock_OnPriceChanged;

            stock.ChangeStockPriceBy(0.05m);
            stock.ChangeStockPriceBy(-0.05m);
            stock.ChangeStockPriceBy(0.00m);

            Console.ReadKey();
        }

        private static void Stock_OnPriceChanged(Stock stock, decimal oldPrice)
        {
           if(stock.Price > oldPrice) {
                Console.ForegroundColor = ConsoleColor.Green;
            }
           else if (stock.Price < oldPrice) {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine($"{stock.Name} price is : {stock.Price}");

        }
    }

    public delegate void StockPriceChangeHandler(Stock stock , decimal oldPrice);
    public class Stock //publisher
    {

        private string name;
        private decimal price;

        public event StockPriceChangeHandler OnPriceChanged;
        public string Name => this.name;
        public decimal Price { get => this.price; set => this.price = value; }

        public Stock(string stockname)
        {
            this.name = stockname;
        }

        public void ChangeStockPriceBy(decimal percent)
        {
            decimal oldPrice = this.price ;
            this.price += Math.Round(this.price * percent , 2);
            if (OnPriceChanged != null)
            { 
                  OnPriceChanged(this, oldPrice); 
            }
        }
    }
};

/*
namespace BirthdayEvent
{
    class Program // subcriber
    {
        static void Main(string[] args)
        {

            var person = new Person("Mohamed Gamal ", new DateTime(2004, 8, 8));

            person.OnBirthday += Person_OnBirthday;


            person.CelebrateBirthday();

            Console.ReadKey();
        }

        private static void Person_OnBirthday(Person person)
        {
            Console.WriteLine($"Happy Birthday {person.Name}! You are now {person.Age} years old.");
        }
    }

    // Delegate for the birthday event
    public delegate void BirthdayHandler(Person person);

    public class Person // publisher 
    {
        private string name;
        private DateTime birthDate;

        public event BirthdayHandler OnBirthday;

        public string Name => name;
        public int Age => DateTime.Now.Year - birthDate.Year;

        public Person(string name, DateTime birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
        }

        // Method to simulate a birthday
        public void CelebrateBirthday()
        {
            if (OnBirthday != null)
            {
                OnBirthday(this); // Trigger the event
            }
        }
    }
}
*/