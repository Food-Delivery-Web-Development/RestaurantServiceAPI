namespace Restaurant.Service.Maps;

using Domain.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class RestaurantMap : IEntityTypeConfiguration<Restaurant>
{
    public void Configure(EntityTypeBuilder<Restaurant> builder)
    {
        builder.ToTable("restaurant");
        builder.HasKey(r => r.Id);

        builder.Property(r => r.Id).ValueGeneratedOnAdd().HasColumnName("id");
        builder.Property(r => r.Name).IsRequired().HasColumnName("name").HasMaxLength(100);
        builder.Property(r => r.Branch).IsRequired().HasColumnName("branch").HasMaxLength(100);
        builder.Property(r => r.LogoUrl).IsRequired().HasColumnName("logo_url").HasMaxLength(255);

        builder
            .HasOne(r => r.Address)
            .WithOne()
            .HasForeignKey<Address>(a => a.RestaurantId)
            .IsRequired();

        builder.HasMany(r => r.Products).WithOne().HasForeignKey(p => p.RestaurantId).IsRequired();
    }
}
