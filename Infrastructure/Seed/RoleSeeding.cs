using Domain.Entity;
using Infrastructure.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class RoleSeedConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.HasData(
            new Role
            {
                Id= Guid.Parse(RoleIds.AdminRole),
                Name = "Admin",
                CreateById = "1"
            },
            new Role
            {
                Id = Guid.Parse(RoleIds.UserRole),
                Name = "User",
                CreateById = "1"
            }
        );
    }
}
