namespace _02.Bonus_Score
{
    using System;

    class BonusScore
    {
        static void Main(string[] args)
        {
            int inputScore = int.Parse(Console.ReadLine());

            if (inputScore > 0 && inputScore < 4)
            {
                Console.WriteLine(inputScore * 10);
            }
            else if (inputScore >= 4 && inputScore <= 6)
            {
                Console.WriteLine(inputScore * 100);
            }
            else if (inputScore > 6 && inputScore <= 9)
            {
                Console.WriteLine(inputScore * 1000);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
