using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bonus_Score
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());

            if (score > 0 && score < 4)
            {
                Console.WriteLine(score * 10);
            }
            else if (score >= 4 && score <= 6)
            {
                Console.WriteLine(score*100);
            }
            else if (score > 6 && score <= 9)
            {
                Console.WriteLine(score*1000);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
