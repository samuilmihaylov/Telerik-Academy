using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Appearance_count
{
    class AppearanceCount
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int count = 0;

            string[] values = Console.ReadLine().Split(' ');

            int givenNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(values[i]);
            }

            count = Appearance_Count(arr,givenNum, count);
            Console.WriteLine(count);
        }

        static int Appearance_Count(int[] array,int given, int countAppearance)
        {
            foreach (int val in array)
            {
                if (val == given)
                {
                    countAppearance++;
                }
            }
            return countAppearance;
        }
    }
}
