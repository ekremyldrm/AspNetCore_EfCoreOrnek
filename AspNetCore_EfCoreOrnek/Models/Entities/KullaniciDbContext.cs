using AspNetCore_EfCoreOrnek.Models.EntitesConfiguration;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore_EfCoreOrnek.Models.Entities
{
    public class KullaniciDbContext : DbContext
    {
        // connectionstringi constructorda gönderiyoruz...
        public KullaniciDbContext(DbContextOptions<KullaniciDbContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // fluent api...
            modelBuilder.Entity<Kullanici>().ToTable("Kullanicis");
            modelBuilder.ApplyConfiguration(new KategoriConfiguration());
        }

        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
    }
}
