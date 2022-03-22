using System;
using System.Collections.Generic;
using System.Linq;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
          int n = int.Parse(Console.ReadLine());
          
          for(int i = 0; i < n; i++) {
            List<string> lista = new List<String>(Console.ReadLine().Split(' '));
            lista = lista.Distinct().ToList();
            lista.Sort();

            foreach(string item in lista) {
              Console.Write($"{item} ");
            }
            
            Console.WriteLine(" ");
          }
          Console.ReadKey();
        }
    }
}
