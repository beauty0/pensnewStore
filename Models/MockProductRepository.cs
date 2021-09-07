using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pensnewStore.Models
{
    public class MockProductRepository : IProductRepository
    {
        // Iproductrespository is created becos of the depency injection
        private List<Product> _productList;
        public MockProductRepository()
        {
            _productList = new List<Product>()
            {
              new Product()  {ProductId= 006, CustomerId = 3,Pen_type = "Skylight", Quantity = 6,
              Price = 5 },
              new Product()  {ProductId= 007, CustomerId = 4,Pen_type = "blurlight", Quantity = 9,
              Price = 6 },
              new Product()  {ProductId= 008, CustomerId = 5,Pen_type = "lightsore", Quantity = 4,
              Price = 3 }


};
    
        }

        public IEnumerable<Product> GetallProducts()
        {
            return _productList;
        }

        // returning product whose id matches with the id
        public Product GetProduct(int ProductId)
        {
            return _productList.FirstOrDefault(p =>p.ProductId == ProductId);
        }
    }
}
