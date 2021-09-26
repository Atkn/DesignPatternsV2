using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesign.Core.builder
{
    public abstract class ProductBuilder 
    {
        public abstract void GetProductData();
        public abstract void ApplyDiscount();
        public abstract ProdcutViewModel BuildModel();

    }
}
