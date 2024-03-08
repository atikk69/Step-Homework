using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Trendyol.Models;

namespace Trendyol.Repository;

public class OrderRepository : Repository<Order>, IOrderRepository
{
    public IEnumerable<Order> GetOrders()
    {
        return _entities.Include(x => x.Users).Include(x => x.Products);

    }

    public OrderRepository(DBContext context) : base(context)
    {
    }
}

