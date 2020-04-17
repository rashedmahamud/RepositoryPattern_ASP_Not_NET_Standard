
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ProductApp.Core;
using ProductApp.Core.Interfaces;

namespace ProductApp.Infrastructure
{
  public  class ProductRepository: IProductRepository
    {
        ProductContext context = new ProductContext();
        public void Add(Product p)
        {
            context.Products.Add(p);
            context.SaveChanges();
        }

        public void Edit(Product p)
        {
            context.Entry(p).State = System.Data.Entity.EntityState.Modified;
        }

        public Product FindById(int Id)
        {
            var result = context.Products.Where(p => p.Id == Id).SingleOrDefault();

            return result;
        }

        public List<Product> GetProducts() { return context.Products.ToList(); }

        public void Delete(int Id)
        {
            var p = context.Products.Find(Id);
            context.Products.Remove(p);
            context.SaveChanges();
        }

        public void Delete(Product P)
        {
            throw new System.NotImplementedException();
        }
    }
}



