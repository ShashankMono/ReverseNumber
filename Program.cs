using ReverseNumber.Models;

namespace ReverseNumber
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Switches();
        }
        public static void Switches()
        {
            bool run = true;
            while (run)
            {
                Console.WriteLine($"\n0.Exit\n" +
                    $"1.Reverse\n");
                int choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 0:
                        run = false;
                        break;

                    case 1:
                        Console.WriteLine("Enter the number");
                        int number = int.Parse(Console.ReadLine());
                        Reverse reverse = new Reverse();
                        Console.WriteLine($"The reverse of the number {number} is {reverse.NumberReverse(number)}");
                        break;
                    default:
                        Console.WriteLine("Please choose correct choise");
                        break;
                }
               
            }
        }
    }
}
