using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.Odd_and_Even_Product
{
    class OddOrEvenProduct
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            while (N >= 4 && N <= 50)
            {
                string[] splitNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                BigInteger evenProduct = 1, oddProduct = 1, zero = 1;

                int[] numbers = new int[50];
                numbers = Array.ConvertAll(splitNumbers, int.Parse);

                for (int i = 0; i < N; i++)
                {
                    int value = numbers[i];

                    if ((i + 1) % 2 == 0 && i != 0)
                    {
                        evenProduct *= value;
                    }

                    if ((i + 1) % 2 == 1)
                    {
                        oddProduct *= value;
                    }
                }

                if (evenProduct == oddProduct)
                {
                    Console.WriteLine("yes {0}", evenProduct);
                    return;
                }
                else
                {
                    Console.WriteLine("no {0} {1}", oddProduct * zero, evenProduct);
                    return;
                }
            }
        }
    }
}



//int N = int.Parse(Console.ReadLine());
//string[] tokens = Console.ReadLine().Split(' ');

//int evenProduct = 1, oddProduct = 1;
//int[] numbers = new int[N];
//int[] evenArray = new int[N];
//int[] oddArray = new int[N];

//numbers = Array.ConvertAll(tokens, int.Parse);

//for (int i = 0; i < N; i++)
//{
//    evenArray = numbers.Where((value, index) => i % 2 == 0).ToArray();
//    oddArray = numbers.Where((value, index) => i % 2 == 1).ToArray();
//}

//foreach (int value in evenArray)
//{
//    evenProduct *= value;
//}

//foreach (int value in oddArray)
//{
//    oddProduct *= value;
//}

//if (evenProduct == oddProduct)
//{
//    Console.WriteLine("yes {0}", evenProduct);
//}
//else
//{
//    Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
//}

///////////////////////////////////////////////////////////////////////////////////////

//int N = int.Parse(Console.ReadLine());
//string[] tokens = Console.ReadLine().Split(' ');

//int[] numbers = new int[N];
//numbers = Array.ConvertAll(tokens, int.Parse);

//int evenProduct = 1, oddProduct = 1;

//foreach (int element in numbers)
//{
//    if (element % 2 == 0)
//    {
//        evenProduct *= element;
//    }
//    else if (element % 2 == 1)
//    {
//        oddProduct *= element;
//    }
//}

//if (evenProduct == oddProduct)
//{
//    Console.WriteLine("yes {0}", evenProduct);
//}
//else
//{
//    Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
//}

