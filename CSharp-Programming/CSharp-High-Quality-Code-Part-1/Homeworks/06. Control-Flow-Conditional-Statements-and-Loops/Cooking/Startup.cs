namespace Cooking
{
    using Cooking.Models;

    public class Startup
    {
        public static void Main(string[] args)
        {
            var chef = new Chef();
            chef.Cook();
        }
    }
}
