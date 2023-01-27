using System.Data.Entity;

namespace Rehber.SINIFLAR
{
    public class RehberContext:DbContext
    {
        public DbSet<Rehber> Rehber { get; set; }
        public DbSet<Unvan> Unvani { get; set; }
        public DbSet<GorevYeri> GorevYeris { get; set; }

    }
}
