namespace Restaurant.Service.Maps;

using Domain.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ProductMap : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("product");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("id");
        builder.Property(p => p.Name).IsRequired().HasColumnName("name").HasMaxLength(100);
        builder
            .Property(p => p.Description)
            .IsRequired()
            .HasColumnName("description")
            .HasMaxLength(1000);
        builder.Property(p => p.Price).IsRequired().HasColumnName("price");
        builder.Property(p => p.ImageUrl).IsRequired().HasColumnName("image_url").HasMaxLength(255);
        builder.Property(p => p.RestaurantId).IsRequired().HasColumnName("restaurant_id");
    }
}
