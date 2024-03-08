using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Models;

namespace Trendyol.Repository
{
    public class WarehouseRepository : Repository<Warehouse>, IWarehouseRepository
    {
        public Warehouse GetByProductId(int productId)
        {
            return _entities.First(x => x.ProductId == productId);
        }
        public WarehouseRepository(DBContext context) : base(context)
        {
        }
    }
}
