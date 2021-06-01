using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("what is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("Your name is: {0}", name);

            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();
            Console.WriteLine("Your age is: {0}", age);

            Console.WriteLine("What month are you born in?");
            var month = Console.ReadLine();
            Console.WriteLine("Your birth month is: {0}", month);
        }
    }
}
