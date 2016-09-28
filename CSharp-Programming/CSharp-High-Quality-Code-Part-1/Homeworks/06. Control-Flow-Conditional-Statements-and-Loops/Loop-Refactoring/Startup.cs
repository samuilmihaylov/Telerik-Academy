namespace LoopRefactoring
{
    using System;
    using System.Linq;

    public class Startup
    {
        private const int MagicGivenNumber = 100;
        private const int ExitStateValue = 666;

        public static void Main(string[] args)
        {
            int[] array = Enumerable.Range(1, MagicGivenNumber).ToArray();
            var randomGen = new Random();

            var index = randomGen.Next(0, array.Length);
            var expectedValue = array[index];

            for (int i = 0; i < MagicGivenNumber; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);

                    if (array[i] == expectedValue)
                    {
                        i = ExitStateValue;
                    }
                }
                else
                {
                    Console.WriteLine(array[i]);
                }

                if (i == ExitStateValue)
                {
                    Console.WriteLine("Value Found");
                    break;
                }
            }
        }
    }
}
