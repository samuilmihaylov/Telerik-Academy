namespace _12.Null_Values_Arithmetic
{
    using System;

    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? var = null;
            double? var2 = null;
            Console.WriteLine(var);
            Console.WriteLine(var2);
            Console.WriteLine(var + 1);

            int sum = (var ?? default(int) + 1);
            Console.WriteLine(sum);
            
        }
    }
}
