using gchs.cos.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gchs.cos.context.mssql.Configurations
{
    public abstract class NamedEntityConfigurations<TEntity> : BaseEntityConfigurations<TEntity>, IEntityTypeConfiguration<TEntity> where TEntity : NamedEntity
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(x => x.ExternalId).HasMaxLength(100);
            builder.Property(x => x.LookupCode).HasMaxLength(100);
            builder.Property(x => x.Name).HasMaxLength(500);
            builder.Property(x => x.Description).HasMaxLength(2000);
            base.Configure(builder);
        }
    }
}
