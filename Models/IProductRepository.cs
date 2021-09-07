using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pensnewStore.Models
{
    public interface IProductRepository
    {
        // OUtputthe list of product
        Product GetProduct(int ProductId);
        IEnumerable<Product> GetallProducts();
    }
}
