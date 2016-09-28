namespace _01.Say_Hello
{
    using System;

    class SayHello
    {
        static void Main(string[] args)
        {
            AskForName();
        }

        static void AskForName()
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
