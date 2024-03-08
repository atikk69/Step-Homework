using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Models;

namespace Trendyol.Repository
{
    public interface IWarehouseRepository : IRepository<Warehouse>
    {
        public Warehouse GetByProductId(int productId);
    }
}
