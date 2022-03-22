using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
          int D = 1;
          
          while(D != 0) {
            D = int.Parse(Console.ReadLine());
            
            if(D == 0){
              break;
            }
            
            if(D % 2 == 0){
              Console.WriteLine(D + (D + 2) + (D + 4) + (D + 6) + (D + 8));
            } else {
              Console.WriteLine((D + 1) + (D + 3) + (D + 5) + (D + 7) + (D + 9));
            }
          }
          Console.ReadKey();
        }
    }
}
