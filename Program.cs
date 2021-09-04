using System;

namespace Exerc_cio_Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string fraseDigitada, fraseComDislalia;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("Digite uma flase: ");
            Console.BackgroundColor = ConsoleColor.Black;
            fraseDigitada = Console.ReadLine();

          fraseComDislalia = fraseDigitada
          .Replace("r" , "l").Replace("R" , "L").Replace("a" ,"4")
          .Replace("A" , "4").Replace("e" , "3").Replace("E" , "3");
          Console.BackgroundColor = ConsoleColor.Yellow;
           Console.ForegroundColor = ConsoleColor.Black;
          Console.WriteLine(fraseComDislalia);
          Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        }
        
    }
}
