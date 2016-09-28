namespace Cooking.Contracts
{
    using Cooking.Enumerations;

    public interface IProduct
    {
        ProductType ProductType { get; }
    }
}
