using Microsoft.EntityFrameworkCore;
using TecnoGas.Web.Models;

namespace TecnoGas.Web.Data
{
    public class TecnoGasDbContext : DbContext
    {
        public TecnoGasDbContext(DbContextOptions<TecnoGasDbContext> options)
            : base(options) { }

        public DbSet<SolicitudServicio> Solicitudes { get; set; }
    }
}