using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Models;

namespace Trendyol.Repository;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    private readonly DBContext _context;
    protected readonly DbSet<T> _entities;

    public Repository(DBContext context)
    {
        _context = context;
        _entities = context.Set<T>();
    }

    public virtual IEnumerable<T> GetAll() =>
        _entities.AsNoTracking().ToList();

    public virtual T? GetById(int id) =>
        _entities.AsNoTracking().SingleOrDefault(s => s.Id == id);

    public virtual T Insert(T entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        _entities.Add(entity);

        return entity;
    }

    public virtual bool Update(T entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        _entities.Update(entity);

        return true;
    }

    public virtual bool Delete(T entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        _entities.Remove(entity);

        return true;
    }

    public virtual int SaveChanges() =>
        _context.SaveChanges();
}
