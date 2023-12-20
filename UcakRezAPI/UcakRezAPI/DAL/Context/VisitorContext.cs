using Microsoft.EntityFrameworkCore;
using UcakRezAPI.DAL.Entities;

namespace UcakRezAPI.DAL.Context
{
    public class VisitorContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ECRE_AKCAY;Database=TraversalDbApi;integrated security=True;");
        }
        public DbSet<Visitor> Visitors { get; set; }
    }
}
