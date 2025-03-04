using Microsoft.EntityFrameworkCore;
using WebApplication8.Models;

public class TaskDbContext : DbContext
{
    public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) { }

    public DbSet<Garson> Garson { get; set; }
    public DbSet<Yemek> Yemekler { get; set; }
    public DbSet<Icecek> Icecekler { get; set; } 
}