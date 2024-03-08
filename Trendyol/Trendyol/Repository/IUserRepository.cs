﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Models;

namespace Trendyol.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        public User GetByEmail(string email);
    }
}
