using BuilderDesign.Core.builder;
using BuilderDesign.Core.director;
using System;

namespace BuilderDesign.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDirector director = new ProductDirector();
            var builder = new NewCustomerProductBuilder();
            director.GenerateProduct(builder);
            var newCustomer = builder.BuildModel();
            Console.WriteLine("Yeni Müşteriler için");
            Console.WriteLine("Kategori İsmi: " + newCustomer.CategoryName);
            Console.WriteLine("İndirimli Fiyatı: " + newCustomer.DiscountedPrice);
            Console.WriteLine("İndirim Uygulandı mı? "  + newCustomer.DiscountApplied);
            Console.WriteLine("Ürün ismi:" + newCustomer.ProductName);
            Console.WriteLine("Ürün fiyat: " + newCustomer.UnitPrice);
            Console.WriteLine("Kimliği: " + newCustomer.Id);
            Console.WriteLine("********************************************************************");
            var builderOld = new OldCustomerProductBuilder();
            director.GenerateProduct(builderOld);
            var oldCustomer = builderOld.BuildModel();
            Console.WriteLine("Eski Müşteriler için");
            Console.WriteLine("Kategori İsmi: " + oldCustomer.CategoryName);
            Console.WriteLine("İndirimli Fiyatı: " + oldCustomer.DiscountedPrice);
            Console.WriteLine("İndirim Uygulandı mı? " + oldCustomer.DiscountApplied);
            Console.WriteLine("Ürün ismi:" + oldCustomer.ProductName);
            Console.WriteLine("Ürün fiyat: " + oldCustomer.UnitPrice);
            Console.WriteLine("Kimliği: " + oldCustomer.Id);

        }
    }
}
