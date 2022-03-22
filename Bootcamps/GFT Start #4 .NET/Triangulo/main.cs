using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
          double a, b, c, calculo;
          string[] valor = Console.ReadLine().Split();
          a = Convert.ToDouble(valor[0]);
          b = Convert.ToDouble(valor[1]);
          c = Convert.ToDouble(valor[2]);

          if(a + b > c && a + c > b && b + c > a) {
            calculo = a + b + c;
            Console.WriteLine("Perimetro = " + calculo.ToString("0.0"));
          } else {
            calculo = (((a + b) * c) / 2);
            Console.WriteLine("Area = " + calculo.ToString("0.0"));
          }
          Console.ReadKey();
        }
    }
}
