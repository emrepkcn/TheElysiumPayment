using Elysium.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Elysium.Repository.Configurations
{
    public class WebLangConfiguration : IEntityTypeConfiguration<WebLang>
    {
        public void Configure(EntityTypeBuilder<WebLang> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Title).IsRequired().HasMaxLength(70);
            builder.Property(x => x.LangId).IsRequired().HasMaxLength(50);
            builder.ToTable("WebLang");
        }
    }
}
