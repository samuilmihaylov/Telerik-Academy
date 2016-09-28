namespace Cooking.Models
{
    using System;
    using Cooking.Contracts;
    using Enumerations;

    public class Vegetable : IVegetable
    {
        public Vegetable(ProductType productType = ProductType.Vegetable)
        {
            this.IsPeeled = false;
            this.IsCutted = false;
        }

        public bool IsPeeled { get; set; }

        public bool IsCutted { get; set; }

        public ProductType ProductType { get; }
    }
}
