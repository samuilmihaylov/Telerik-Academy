namespace _09.Exchange_Variable_Values
{
    using System;

    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {

            int variableA = 5;
            int variableB = 10;
            int temporalVariable;

            Console.WriteLine($"Before exchange: a = {variableA} b = {variableB}");

            temporalVariable = variableA; // c = 5
            variableA = variableB; // a = 10 
            variableB = temporalVariable; // b = 5

            Console.WriteLine($"After exchange: a = {variableA} b = {variableB}");
        }
    }
}
