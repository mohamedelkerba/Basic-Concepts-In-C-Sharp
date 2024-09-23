namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Dollar dollar = new Dollar(48.12m);

            dollar.SetAmount(50);

            Console.WriteLine(dollar.Amount);

            Console.ReadLine();
        }
    }

    public class Dollar
    {
        private decimal _amount;

        public decimal Amount
        {
            get {
                return this._amount; 
            } 

            // البنك هو اللي يقدر يحط السعر ...لكن المستهلك عاوز يشوف السعر بس ميقدرش يعدل فيه حاجة 
            private set 
            {
                this._amount = ProcessValue(value);
            }
        }

        public void SetAmount(decimal value)
        {
            Amount = value;
        }
        public Dollar(decimal amount) {
            this._amount = ProcessValue(amount);
        }

        private decimal ProcessValue( decimal value ) => value<=0 ? 0 : Math.Round(value);

    }
}
