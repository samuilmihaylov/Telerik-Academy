namespace Cooking.Models
{
    using System;
    using System.Collections.Generic;

    using Cooking.Contracts;

    public class Bowl : IContainer
    {
        private IList<IProduct> products;

        public Bowl()
        {
            this.products = new List<IProduct>();
        }

        public IList<IProduct> Contents
        {
            get
            {
                return this.products;
            }

            set
            {
                this.products = value;
            }
        }

        public void Add(IProduct product)
        {
            this.Contents.Add(product);
        }
    }
}
