using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesign.Core.builder
{
    public class NewCustomerProductBuilder : ProductBuilder
    {
        ProdcutViewModel model = new ProdcutViewModel();
        public override void ApplyDiscount()
        {
            model.DiscountedPrice = model.UnitPrice*(decimal)0.90;
            model.DiscountApplied = true;
        }

        public override ProdcutViewModel BuildModel()
        {
            return model;
        }

        public override void GetProductData()
        {
            model.Id = 1;
            model.CategoryName = "Kategori";
            model.ProductName = "Test ürünü";
            model.UnitPrice = 20;
        }
    }
}
