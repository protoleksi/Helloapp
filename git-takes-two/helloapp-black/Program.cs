using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello everyone");
            greetWhite();
            greetBlack();
        }

        static void greetWhite()
        {
            Console.WriteLine("hello white");
        }

        static void greetBlack()
        {
            Console.WriteLine("hello black");
        }
    }
}