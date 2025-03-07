using AspNetCore_EfCoreOrnek.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetCore_EfCoreOrnek.Models.EntitesConfiguration
{
    public class KategoriConfiguration : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(c => c.KategoriId);
            builder.Property(c => c.KategoriId).HasColumnName("Id");
            builder.Property(c => c.KategoriAdi).HasColumnName("Name").HasMaxLength(50);
            builder.Property(c => c.KategoriAciklama).HasColumnName("Description").HasMaxLength(500);
        }
    }
}
