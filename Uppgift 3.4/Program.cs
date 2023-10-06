using System;
namespace Uppgift3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många minuter lång är låten?");
            int minuter = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många sekunder lång är låten?");
            int sekunder = int.Parse(Console.ReadLine());
            if ((minuter >= 2 && sekunder >= 45) || (minuter <= 4 && sekunder <= 20))
            {
                Console.WriteLine("Din låt får spelas på radiostationen.");
            }
            else if ((minuter >= 4 && sekunder > 20) || (minuter > 4 && sekunder <= 20))
            {
                Console.WriteLine("Din låt är för lång.");
            }
            else
            {
                Console.WriteLine("Din låt är för kort.");
            }
            Console.ReadKey();
        }
    }
}