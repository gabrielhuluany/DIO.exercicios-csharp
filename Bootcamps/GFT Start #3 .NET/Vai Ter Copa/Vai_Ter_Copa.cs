using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        { 
          string str;
          while ((str=Console.ReadLine())!= null)
          {
            int x = int.Parse(str);
            
            if (x == 0)
            {
                Console.WriteLine("vai ter copa!");
            }
            else
            {
                Console.WriteLine("vai ter duas!");
            }
          }
        }
    }
}
