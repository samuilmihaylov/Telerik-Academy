namespace _03.Variable_in_Hexadecimal_Format
{
    using System;

    class VariableInHexadecimalFormat
    {
        static void Main(string[] args)
        {

            int integerVariable = 254;
            string hexadecimalValue = integerVariable.ToString("X");

            Console.WriteLine("The number 254 in hexadecimal is: " + hexadecimalValue);
        }
    }
}
