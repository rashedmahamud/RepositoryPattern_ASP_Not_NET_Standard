

using ProductApp.Core;
using ProductApp.Infrastructure;
using System.Data.Entity;

namespace ProductApp.Infrastructure
{
  public class ProductInitalizeDB : DropCreateDatabaseIfModelChanges<ProductContext>
    {
         protected override void Seed(ProductContext context)
         {
             context.Products.Add(new Product { Id = 1, Name = "Rice", inStock = true, Price = 30 });
             context.Products.Add(new Product { Id = 2, Name = "Sugar", inStock = false, Price = 40 });
             context.SaveChanges(); base.Seed(context);
         }
   }
}