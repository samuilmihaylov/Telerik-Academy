namespace Cooking.Models
{
    using Cooking.Contracts;

    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();
            Bowl bowl = this.GetBowl();

            this.Peel(potato);
            this.Cut(potato);
            bowl.Add(potato);

            this.Peel(carrot);
            this.Cut(carrot);
            bowl.Add(carrot);
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private void Cut(IVegetable vegetable)
        {
            vegetable.IsCutted = true;
        }

        private void Peel(IVegetable vegetable)
        {
            vegetable.IsPeeled = true;
        }
    }
}
