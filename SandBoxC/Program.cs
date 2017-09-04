using System;


namespace SandBoxC
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            if (input.Equals("Jp"))
            {
                Console.WriteLine("What's up Jp!!!");
            }
            else if (input.Equals("Joe"))
            {
                Console.WriteLine("What's up Joe!!!");
            }
            else
            {
                Console.WriteLine("Who the hell are you??!!!");
            }
            switch (input)
            {
                case "Jp":
                    Console.WriteLine("What's up Jp!!!");
                    break;
                case "Joe":
                    Console.WriteLine("What's up Joe!!!");
                    break;
                default:
                    Console.WriteLine("Who the hell are you??!!!");
                    break;
            }
        }
    }
}
