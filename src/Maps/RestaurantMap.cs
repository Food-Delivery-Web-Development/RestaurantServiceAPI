namespace Restaurant.Service.Maps;

using Domain.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class RestaurantMap : IEntityTypeConfiguration<Restaurant>
{
    public void Configure(EntityTypeBuilder<Restaurant> builder)
    {
        builder.ToTable("restaurant");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
        builder.Property(x => x.Name).IsRequired().HasColumnName("name").HasMaxLength(100);
        builder.Property(x => x.Branch).IsRequired().HasColumnName("branch").HasMaxLength(100);
        builder.Property(x => x.AddressId).IsRequired().HasColumnName("address_id");

        builder.HasMany<Product>().WithOne().HasForeignKey(p => p.RestaurantId).IsRequired();
    }
}
