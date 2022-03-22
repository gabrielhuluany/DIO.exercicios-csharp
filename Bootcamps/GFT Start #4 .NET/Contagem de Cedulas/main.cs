using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
          int resto, nota, quociente;
          
          resto = int.Parse(Console.ReadLine());
          Console.WriteLine(resto);
          
          nota = 100;
          quociente = resto / 100;
          Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
          resto = resto % 100;
          
          nota = 50;
          quociente = resto / 50;
          Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
          resto = resto % 50;
          
          nota = 20;
          quociente = resto / 20;
          Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
          resto = resto % 20;
          
          nota = 10;
          quociente = resto / 10;
          Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
          resto = resto % 10;
          
          nota = 5;
          quociente = resto / 5;
          Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
          resto = resto % 5;
          
          nota = 2;
          quociente = resto / 2;
          Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
          resto = resto % 2;
          
          nota = 1;
          quociente = resto / 1;
          Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
          resto = resto % 1;
        }
    }
}
