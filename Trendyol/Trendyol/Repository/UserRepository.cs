using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Trendyol.Models;

namespace Trendyol.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public User GetByEmail(string email)
        {
            return _entities.Single(x => x.Email == email);
            
        }
            
        public UserRepository(DBContext context) : base(context)
        {
        }
    }
}
