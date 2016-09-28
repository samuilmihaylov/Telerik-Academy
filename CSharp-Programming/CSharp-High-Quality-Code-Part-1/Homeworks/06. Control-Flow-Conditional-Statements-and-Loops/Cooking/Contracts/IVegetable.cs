namespace Cooking.Contracts
{
    public interface IVegetable : IProduct
    {
        bool IsPeeled { get; set; }

        bool IsCutted { get; set; }
    }
}
