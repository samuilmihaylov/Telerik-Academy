namespace _03.Check_for_a_Play_Card
{
    using System;

    class CheckForAPlayCard
    {
        static void Main(string[] args)
        {
            string inputCard = Console.ReadLine();

            string outputMessage = string.Format("yes {0}", inputCard);

            switch (inputCard)
            {
                case "2":
                    Console.WriteLine(outputMessage);
                    break;
                case "3":
                    Console.WriteLine(outputMessage);
                    break;
                case "4":
                    Console.WriteLine(outputMessage);
                    break;
                case "5":
                    Console.WriteLine(outputMessage);
                    break;
                case "6":
                    Console.WriteLine(outputMessage);
                    break;            
                case "7":             
                    Console.WriteLine(outputMessage);
                    break;          
                case "8":             
                    Console.WriteLine(outputMessage);
                    break;
                case "9":
                    Console.WriteLine(outputMessage);
                    break;
                case "10":
                    Console.WriteLine(outputMessage);
                    break;
                case "A":
                    Console.WriteLine(outputMessage);
                    break;
                case "J":
                    Console.WriteLine(outputMessage);
                    break;
                case "Q":
                    Console.WriteLine(outputMessage);
                    break;
                case "K":
                    Console.WriteLine(outputMessage);
                    break;
                default:
                    Console.WriteLine("no {0}", inputCard); ;
                    break;
            }
        }
    }
}
