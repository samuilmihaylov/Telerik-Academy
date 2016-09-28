namespace RefactorFollowingStatements.CookingPotatoRefactoring
{
    using System;

    public class Cooker
    {
        public bool IsReadyForCooking(Potato potato)
        {
            if (potato != null)
            {
                if (potato.IsPilled && potato.IsRotten)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void Cook(Potato potato)
        {
            if (this.IsReadyForCooking(potato))
            {
                potato.IsCooked = true;
            }
        }
    }
}
