namespace Cooking.Contracts
{
    using System.Collections.Generic;

    public interface IContainer
    {
        IList<IProduct> Contents { get; set; }

        void Add(IProduct product);
    }
}
