using Elysium.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Elysium.Repository.Configurations
{
    public class LoggerConfiguration : IEntityTypeConfiguration<Logger>
    {
        public void Configure(EntityTypeBuilder<Logger> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Exception);
            builder.Property(x => x.UserId).IsRequired().HasMaxLength(50);
            builder.ToTable("Logger");
        }
    }
}
