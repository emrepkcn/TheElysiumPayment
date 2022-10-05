using Elysium.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Elysium.Repository.Configurations
{
    public class ProductLabelConfiguration : IEntityTypeConfiguration<ProductLabel>
    {
        public void Configure(EntityTypeBuilder<ProductLabel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Title).IsRequired().HasMaxLength(70);
            builder.Property(x => x.LangId).IsRequired().HasMaxLength(50);
            builder.ToTable("ProductLabel");
        }
    }
}
