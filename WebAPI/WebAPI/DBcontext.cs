using Microsoft.EntityFrameworkCore;
using System;
using WebAPI.Models;


namespace WebAPI;

internal class DBContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Department> Departments { get; set; }

    public DBContext()
    {
        
    }
    public DBContext(DbContextOptions<DBContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
}
