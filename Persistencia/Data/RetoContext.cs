using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Data
{
    public class RetoContext : DbContext
    {
        public RetoContext(DbContextOptions<RetoContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}