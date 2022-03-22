using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
          int A = int.Parse(Console.ReadLine());
          int B = int.Parse(Console.ReadLine());
          int C = int.Parse(Console.ReadLine());
          int D = int.Parse(Console.ReadLine());
          
          Console.WriteLine("DIFERENCA = " + (A * B - C * D));
          Console.ReadKey();
        }
    }
}
