using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Models;

namespace Trendyol.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public bool DeleteProduct(Product product)
        {
            _entities.Remove(product);
            return true;
        }
        public ProductRepository(DBContext context) : base(context)
        {
        }
    }
}
