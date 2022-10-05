using Elysium.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Elysium.Repository.Configurations
{
    public class CookiePoliciesConfiguration : IEntityTypeConfiguration<CookiePolicies>
    {
        public void Configure(EntityTypeBuilder<CookiePolicies> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.UserId).IsRequired();
            builder.ToTable("CookiePolicies");
        }
    }
}
