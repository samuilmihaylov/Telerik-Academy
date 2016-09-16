namespace _07.Sort_3_Numbers
{
    using System;

    class Sort3Numbers
    {
        static void Main(string[] args)
        {
            short numberA = short.Parse(Console.ReadLine());
            short numberB = short.Parse(Console.ReadLine());
            short numberC = short.Parse(Console.ReadLine());

            bool isTrue = (numberA >= -1000 && numberA <= 1000) &&
                    (numberB >= -1000 && numberB <= 1000) && 
                    (numberC >= -1000 && numberA <= 1000);

            while (isTrue)
            {
                if (numberA > numberB)
                {
                    if (numberA > numberC)
                    {
                        if (numberB > numberC)
                        {
                            Console.WriteLine("{0} {1} {2}", numberA, numberB, numberC);
                            return;
                        }
                        else
                        {
                            Console.WriteLine("{0} {1} {2}", numberA, numberC, numberB);
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2}", numberC, numberA, numberB);
                        return;
                    }
                }
                else if (numberB > numberC)
                {
                    if (numberA > numberC)
                    {
                        Console.WriteLine("{0} {1} {2}", numberB, numberA, numberC);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2}", numberB, numberC, numberA);
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", numberC, numberB, numberA);
                    return;
                }
            }

            return;
        }
    }
}
