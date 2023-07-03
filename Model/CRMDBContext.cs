using Microsoft.EntityFrameworkCore;

namespace App_CRM.Model
{
	public class CRMDBContext : DbContext
	{
        public CRMDBContext(DbContextOptions<CRMDBContext> options) : base (options)
        {
            
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Servicio> Servicio { get; set; }
        public DbSet<Contrato> Contrato { get; set; }
        public DbSet<TareaPendiente> TareaPendiente { get; set; }
    }
}
