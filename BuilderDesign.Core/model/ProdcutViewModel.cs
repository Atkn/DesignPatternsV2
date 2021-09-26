using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesign.Core
{
    public class ProdcutViewModel
    {
        public int Id { get; set; }
        public decimal DiscountedPrice { get; set; }
        public bool DiscountApplied { get; set; }
        public string CategoryName{ get; set; }
        public string ProductName{ get; set; }
        public decimal UnitPrice{ get; set; }
    }
}
