using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Core.Interfaces
{
   public interface IProductRepository
    {
        void Add(Product P);
        void Edit(Product P);
        void Delete(Product P);
        List<Product> GetProducts();
        Product FindById(int Id);

    }
}
