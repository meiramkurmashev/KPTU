using System.Data.Entity;
namespace KPTU.Models
{

    public class WagonContext : DbContext

    {
        public DbSet<Wagon> Wagons { get; set; }
        public DbSet<Loading> Loadings { get; set; }

    }
}