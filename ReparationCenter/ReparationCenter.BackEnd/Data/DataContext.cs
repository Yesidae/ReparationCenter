using Microsoft.EntityFrameworkCore;
using ReparationCenter.Shared.Entities;

namespace ReparationCenter.BackEnd.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                
        }

        public DbSet<MyReparation> MyReparations { get; set; }
    }
}
