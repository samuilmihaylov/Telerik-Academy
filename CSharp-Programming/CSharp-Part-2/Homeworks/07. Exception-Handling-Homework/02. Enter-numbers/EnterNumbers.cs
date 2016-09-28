namespace _02.Enter_numbers
{
    using System;
    using System.Text;

    class EnterNumbers
    {
        static int EnterNumber(int start, int end)
        {
            int number = 0;

            try
            {
                number = int.Parse(Console.ReadLine());

                if (number <= start || number >= end)
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (FormatException)
            {
                throw new FormatException();
            }

            return number;
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int currentNum = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = EnterNumber(0, 100);

                try
                {
                    if (currentNum < numbers[i])
                    {
                        currentNum = numbers[i];

                        continue;
                    }
                    else if (currentNum > numbers[i] || currentNum == numbers[i])
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Exception");

                    return;
                }
            }

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in numbers)
            {
                stringBuilder.Append(item + " < ");
            }

            Console.WriteLine("1 < " + stringBuilder.ToString() + "100");
        }
    }
}
