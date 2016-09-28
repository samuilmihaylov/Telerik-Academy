namespace _06.String_length
{
    using System;
    using System.Text;

    class StringLength
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder();

            inputString = inputString.Replace(@"\", string.Empty);
            stringBuilder.Append(inputString);

            for (int i = inputString.Length; i < 20; i++)
            {
                stringBuilder.Append("*");
            }
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
