using BuilderDesign.Core.builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesign.Core.director
{
    public class ProductDirector 
    {
        public void GenerateProduct(ProductBuilder productBuilder)
        {
            productBuilder.GetProductData();
            productBuilder.ApplyDiscount();
        }
    }
}
