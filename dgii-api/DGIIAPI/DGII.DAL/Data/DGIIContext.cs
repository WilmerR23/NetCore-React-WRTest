using Microsoft.EntityFrameworkCore;
using DGII.BOL.Models;
using System.Reflection;
using Microsoft.AspNetCore.SignalR;
using DGII.BLL.Contracts;

namespace DGII.DAL.Data
{
    public class DGIIContext : DbContext, IDbContext
    {
        public DGIIContext(DbContextOptions<DGIIContext> options) : base(options)
        {
        }

        public DbSet<TipoContribuyente> Tipos { get; set; }
        public DbSet<EstadoContribuyente> Estados { get; set; }
        public DbSet<Contribuyente> Contribuyentes { get; set; }
        public DbSet<Comprobante> Comprobantes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // Configurar todas las configuraciones mediante reflection
            base.OnModelCreating(modelBuilder);
        }
    }
}
