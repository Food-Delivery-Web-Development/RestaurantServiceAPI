namespace Restaurant.Service.Maps;

using Domain.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AddressMap : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("address");
        builder.HasKey(a => a.Id);

        builder.Property(a => a.Id).ValueGeneratedOnAdd().HasColumnName("id");
        builder.Property(a => a.Street).IsRequired().HasColumnName("street").HasMaxLength(100);
        builder.Property(a => a.City).IsRequired().HasColumnName("city").HasMaxLength(100);
        builder.Property(a => a.Country).IsRequired().HasColumnName("country").HasMaxLength(100);
        builder.Property(a => a.RestaurantId).IsRequired().HasColumnName("restaurant_id");
    }
}
