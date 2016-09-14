using System;

namespace _07.Sort_3_Numbers
{
    class Sort3Numbers
    {
        static void Main(string[] args)
        {
            short A = short.Parse(Console.ReadLine());
            short B = short.Parse(Console.ReadLine());
            short C = short.Parse(Console.ReadLine());

            bool isTrue = (A >= -1000 && A <= 1000) && (B >= -1000 && B <= 1000) && (C >= -1000 && A <= 1000);

            while (isTrue)
            {
                if (A > B)
                {
                    if (A > C)
                    {
                        if (B > C)
                        {
                            Console.WriteLine("{0} {1} {2}", A, B, C);
                            return;
                        }
                        else
                        {
                            Console.WriteLine("{0} {1} {2}", A, C, B);
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2}", C, A, B);
                        return;
                    }
                }

                else if (B > C)
                {
                    if (A > C)
                    {
                        Console.WriteLine("{0} {1} {2}", B, A, C);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2}", B, C, A);
                        return;
                    }
                }

                else
                {
                    Console.WriteLine("{0} {1} {2}", C, B, A);
                    return;
                }
            }
            return;
        }
    }
}
