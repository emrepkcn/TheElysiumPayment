using Elysium.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Elysium.Repository.Configurations
{
    public class WebUserConfiguration : IEntityTypeConfiguration<WebUser>
    {
        public void Configure(EntityTypeBuilder<WebUser> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Surname).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(70);
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(12);
            builder.Property(x => x.HotelsId).IsRequired();
            builder.Property(x => x.RoomNumber).IsRequired();
            builder.ToTable("WebUsers");
        }
    }
}
