namespace CAIndexers
{
    class Program
    {
        static void Main(string[] args)
        {
             var ip = new Ip(192,168,1,1);       // first way
            // var ip = new Ip("192.168.1.1");   //  second way 
             Console.WriteLine(ip.Address);

             Console.WriteLine($"First Ip : {ip[0]}");



            ///////////////////////////////
          
            int[,] inputs = new int[ , ]
            {
                {8,4,6,7,8,9,10,15},
                {8,4,6,7,8,9,10,15},
                {8,4,6,7,8,9,10,15},
                {8,4,6,7,8,9,10,7},
                {8,4,6,7,8,9,10,44},
                {8,4,6,7,8,9,10,15},
            };
            var suduko = new Suduko(inputs);
            Console.WriteLine(suduko[4,7]);
        
            Console.ReadKey();
        }
    }
    public class Ip
    {
        private int[] segments = new int[4];

        public int this[int index]
        {
            get
            {
                return segments[index];
            }

            set
            {
                segments[index] = value;
            }

        }

        // second way to input 
        public Ip(string IPAddress)
        {

            var segs = IPAddress.Split('.');
            for (int i = 0; i < segs.Length; i++)
            {
                segments[i] = Convert.ToInt32(segs[i]);

            }

        }

        // first way  to input
        public Ip(int segment1, int segment2, int segment3, int segment4)
        {
            segments[0] = segment1;
            segments[1] = segment2;
            segments[2] = segment3;
            segments[3] = segment4;

        }





        public string Address => string.Join(".", segments);

    }
    public class Suduko
    {
        private int[,] _matrix ;

        public int this [int row , int column]
        {
            get
            {
                return _matrix[row , column];   
            }

            set { 
                _matrix[row , column] = value;
            }
        }

        public Suduko(int [,] matrix)
        {

            _matrix = matrix;
        }
    }

    

}
