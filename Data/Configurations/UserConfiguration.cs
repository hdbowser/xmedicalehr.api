using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xmedical_ehr.Account;

namespace xmedical_ehr.Data.Migrations.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Name)
                .HasColumnType("varchar(150)");

            builder.Property(x => x.Prefix)
                .HasColumnName("varchar(45)");

            builder.HasData(
                new User
                {
                    Id = System.Guid.NewGuid().ToString(),
                    UserName = "root@system.local",
                    NormalizedUserName = "ROOT@SYSTEM.LOCAL",
                    Email = "root@system.local",
                    NormalizedEmail = "ROOT@SYSTEM.LOCAL",
                    SecurityStamp = "6XKETTFVMB3X6M4ENBW6YYVZYCTO52XW",
                    PasswordHash = "AQAAAAEAACcQAAAAEBEI92DDQ3rQr8oCpJKHlvz1hN/VDJpzGkFdV3qEHSjAQdLm5q6JEvzmS6sJpQnHMw==",
                    ConcurrencyStamp = "d9b82e89-edd5-48a0-a728-7e92c90fb921",
                    Name = "Root",
                    AccessFailedCount = 0,
                    Prefix = "Sr"
                }
            );
        }

    }
}