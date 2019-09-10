using System;

namespace details_of_customer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is ur name");
            var name = Console.ReadLine();

            Console.WriteLine("what is your age");
            var age = Console.ReadLine();

            Console.WriteLine("what is your birth month");
            var month = Console.ReadLine();

            if(month=="july")

            {
                Console.WriteLine("you are a cancer");
            }
        }
    }
}
