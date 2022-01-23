using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW4.Entities;

namespace Module4HW4.EntityConfigurations;

public class ProjectConfiguration : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        builder.ToTable("Project").HasKey(p => p.Id);
        builder.Property(p => p.Id).HasColumnName("ProjectId").ValueGeneratedOnAdd();
        builder.Property(p => p.Name).IsRequired().HasColumnName("Name").HasMaxLength(50);
        builder.Property(p => p.Budget).IsRequired().HasColumnName("Budget").HasColumnType("money");
        builder.Property(p => p.StartedDate).IsRequired().HasColumnName("StartedDate").HasMaxLength(7);

        builder.HasOne(p => p.Client)
            .WithMany(c => c.Projects)
            .HasForeignKey(h => h.ClientId);
    }
}