using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedicalehr.api.Account;

namespace xmedicalehr.api.Data.Migrations.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(x => x.DisplayName)
                .HasColumnType("varchar(150)");
            
            
            builder.HasData(new Role[]{
                new Role{
                    Id = Guid.NewGuid().ToString(),
                    Name = "admin",
                    DisplayName = "Administrador",
                    NormalizedName = "ADMINISTRADOR"
                },

                new Role{
                    Id = Guid.NewGuid().ToString(),
                    Name = "user",
                    DisplayName = "User",
                    NormalizedName = "USER"
                }
            });
        }
    }
}