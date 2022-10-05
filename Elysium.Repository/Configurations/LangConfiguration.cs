using Elysium.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Elysium.Repository.Configurations
{
    public class LangConfiguration : IEntityTypeConfiguration<Lang>
    {
        public void Configure(EntityTypeBuilder<Lang> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Title).IsRequired().HasMaxLength(10);
            builder.ToTable("Lang");
        }
    }
}
