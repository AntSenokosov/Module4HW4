using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW4.Entities;

namespace Module4HW4.EntityConfigurations;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.ToTable("Client").HasKey(c => c.Id);
        builder.Property(e => e.Id).HasColumnName("ClientId").ValueGeneratedOnAdd();
        builder.Property(e => e.FirstName).IsRequired().HasColumnName("FirstName").HasMaxLength(50);
        builder.Property(e => e.LastName).IsRequired().HasColumnName("LastName").HasMaxLength(50);
        builder.Property(e => e.Email).IsRequired().HasColumnName("Email");
        builder.Property(e => e.Phone).IsRequired().HasColumnName("Phone").HasMaxLength(15);
    }
}