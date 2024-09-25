using System;
namespace CAFinalizers
{
    class Program
    {
        static void Main(string[] args)
        {

            MakeSomeGarbage();
            Console.WriteLine($"Memory Used Befor Collecting : {GC.GetTotalMemory(false) :N0}");
            GC.Collect(); //Explict Cleaning
            Console.WriteLine($"Memory Used After Collection : {GC.GetTotalMemory(true):N0}");
            Console.ReadKey();
        }

        static void MakeSomeGarbage() {
            Version v;
            for (int i = 0; i < 1000; i++) { 
             v = new Version();
            }
        
        }
    }

}