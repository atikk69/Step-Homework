using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Models;

namespace Trendyol.Repository;

public interface IRepository<T> where T : BaseEntity
{   
    public IEnumerable<T> GetAll();
    public T? GetById(int id);
    public T Insert(T entity);
    public bool Update(T entity);
    public bool Delete(T entity);
    public int SaveChanges();
}

