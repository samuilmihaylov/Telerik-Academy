using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Enter_numbers
{
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

            StringBuilder sb = new StringBuilder();

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

            foreach (var item in numbers)
            {
                sb.Append(item + " < ");
            }

            Console.WriteLine("1 < " + sb.ToString() + "100");
        }
    }
}
