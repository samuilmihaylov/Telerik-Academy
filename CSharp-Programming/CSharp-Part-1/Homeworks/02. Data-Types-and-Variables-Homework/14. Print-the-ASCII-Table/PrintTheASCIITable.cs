namespace _14.Print_the_ASCII_Table
{
    using System;

    class PrintTheASCIITable
    {
        static void Main(string[] args)
        {
            int ASCIICode;
            for (ASCIICode = 32; ASCIICode <= 126; ASCIICode++)
            {
                char symbol = Convert.ToChar(ASCIICode);
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }
}
