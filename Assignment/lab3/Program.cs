using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("This is a calculator app");
             Console.Write("Type in your Prime number: ");
             int PrimeNumber = int.Parse(Console.ReadLine());
             Console.WriteLine("The value you entered is a Prime number");
             Console.Write("Type in your second number: ");
             int secondNumber = int.Parse(Console.ReadLine());
             Console.WriteLine("The value you entered is a not Prime number");
        }
    }
}
