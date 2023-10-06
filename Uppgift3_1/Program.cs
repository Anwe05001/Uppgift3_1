using System; 

namespace uppgift_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du? (i år)");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder >= 50)
            {
                Console.WriteLine("Du får delta i seniormästerskapen");
            }
            if (ålder <= 50)
            {
                Console.WriteLine("Du får INTE delta i seniorästerskapen");
            }
        }
    }
}