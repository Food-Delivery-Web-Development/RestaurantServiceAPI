namespace Restaurant.Service.Maps;

using Domain.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AddressMap : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("address");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
        builder.Property(x => x.Street).IsRequired().HasColumnName("street").HasMaxLength(100);
        builder.Property(x => x.City).IsRequired().HasColumnName("city").HasMaxLength(100);
        builder.Property(x => x.Country).IsRequired().HasColumnName("country").HasMaxLength(100);

        builder
            .HasOne<Restaurant>()
            .WithOne(r => r.Address)
            .HasForeignKey<Restaurant>(r => r.AddressId)
            .IsRequired();
    }
}
