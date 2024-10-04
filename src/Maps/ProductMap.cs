namespace Restaurant.Service.Maps;

using Domain.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ProductMap : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("product");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
        builder.Property(x => x.Name).IsRequired().HasColumnName("name").HasMaxLength(100);
        builder
            .Property(x => x.Description)
            .IsRequired()
            .HasColumnName("description")
            .HasMaxLength(1000);
        builder.Property(x => x.Price).IsRequired().HasColumnName("price");
        builder.Property(x => x.RestaurantId).IsRequired().HasColumnName("restaurant_id");
    }
}
