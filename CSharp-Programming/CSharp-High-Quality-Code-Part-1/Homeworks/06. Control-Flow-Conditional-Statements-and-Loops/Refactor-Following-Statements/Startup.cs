namespace RefactorFollowingStatements
{
    using RefactorFollowingStatements.CookingPotatoRefactoring;

    public class Startup
    {
        public static void Main(string[] args)
        {
            var cooker = new Cooker();
            var potato = new Potato();

            cooker.IsReadyForCooking(potato);
        }
    }
}
