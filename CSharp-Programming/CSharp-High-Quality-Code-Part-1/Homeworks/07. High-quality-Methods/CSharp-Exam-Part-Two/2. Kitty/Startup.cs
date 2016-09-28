namespace _2.Kitty
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public class Startup
    {
        private static string input;
        private static int kittyCurrentIndex;

        public static void Main()
        {
            input = Console.ReadLine();

            var path = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(x => BigInteger.Parse(x))
                                         .ToArray();

            // @
            int souls = 0;

            // *
            int food = 0;

            // x
            int deadlocks = 0; 

            kittyCurrentIndex = 0;

            StringBuilder sb = new StringBuilder(input);

            int jumps = 0;

            // Stop the program if the first one is deadlock.
            if (sb[0] == 'x') 
            {
                Console.WriteLine("You are deadlocked, you greedy kitty!");
                Console.WriteLine("Jumps before deadlock: {0}", 0);
                return;
            }

            for (int i = 0; i < path.Length; i++)
            {
                if (sb[kittyCurrentIndex] == '@')
                {
                    sb.Replace('@', ' ', kittyCurrentIndex, 1);
                    souls++;
                }
                else if (sb[kittyCurrentIndex] == '*')
                {
                    sb.Replace('*', ' ', kittyCurrentIndex, 1);
                    food++;
                }
                else if (sb[kittyCurrentIndex] == 'x')
                {              
                    deadlocks++;

                    if (kittyCurrentIndex % 2 == 0)
                    {
                        sb.Replace('x', '@', kittyCurrentIndex, 1);
                        souls--;

                        if (souls < 0)
                        {
                            Console.WriteLine("You are deadlocked, you greedy kitty!");
                            Console.WriteLine("Jumps before deadlock: {0}", jumps);
                            return;
                        }
                    }
                    else if (kittyCurrentIndex % 2 != 0)
                    {
                        sb.Replace('x', '*', kittyCurrentIndex, 1);
                        food--;

                        if (food < 0)
                        {
                            Console.WriteLine("You are deadlocked, you greedy kitty!");
                            Console.WriteLine("Jumps before deadlock: {0}", jumps);
                            return;
                        }         
                    }
                }

                // Move right.
                if (path[i] > 0)
                {
                    kittyCurrentIndex = (int)((kittyCurrentIndex + path[i]) % input.Length);
                }

                // Move left.
                if (path[i] < 0) 
                {
                    kittyCurrentIndex = (int)((kittyCurrentIndex + path[i]) % input.Length);

                    if (kittyCurrentIndex < 0)
                    {
                        kittyCurrentIndex += input.Length;
                    }
                }

                jumps++;
            }

            // One more time, for the last element of path
            if (sb[kittyCurrentIndex] == '@')
            {
                sb.Replace('@', ' ', kittyCurrentIndex, 1);
                souls++;
            }
            else if (sb[kittyCurrentIndex] == '*')
            {
                sb.Replace('*', ' ', kittyCurrentIndex, 1);
                food++;
            }
            else if (sb[kittyCurrentIndex] == 'x')
            {
                deadlocks++;

                if (kittyCurrentIndex % 2 == 0)
                {
                    souls--;

                    if (souls < 0)
                    {
                        Console.WriteLine("You are deadlocked, you greedy kitty!");
                        Console.WriteLine("Jumps before deadlock: {0}", jumps);
                        return;
                    }
                }
                else if (kittyCurrentIndex % 2 != 0)
                {
                    food--;

                    if (food < 0)
                    {
                        Console.WriteLine("You are deadlocked, you greedy kitty!");
                        Console.WriteLine("Jumps before deadlock: {0}", jumps);
                        return;
                    }
                }

                sb.Replace('x', ' ', kittyCurrentIndex, 1);
            }

            Console.WriteLine("Coder souls collected: {0}", souls);
            Console.WriteLine("Food collected: {0}", food);
            Console.WriteLine("Deadlocks: {0}", deadlocks);
        }
    }
}
