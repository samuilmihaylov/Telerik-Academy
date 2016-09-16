namespace _09.Int__Double_and_String
{
    using System;

    class IntDoubleString
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();

            switch (inputType)
            {
                case "integer":
                    int integerNumberValue = int.Parse(Console.ReadLine());
                    integerNumberValue += 1;
                    Console.WriteLine(integerNumberValue);
                    break;
                case "real":
                    double realNumberValue = double.Parse(Console.ReadLine());
                    realNumberValue += 1;
                    Console.WriteLine(realNumberValue.ToString("F2"));
                    break;
                case "text":
                    string text = Console.ReadLine();
                    Console.WriteLine(text + "*");
                    break;
            }
        }
    }
}
