using gchs.cos.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gchs.cos.context.mssql.Configurations
{
    public abstract class BaseEntityConfigurations<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            //ID
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();
            //Active
            builder.Property(x => x.Active).HasDefaultValue(true);
            builder.Property(x => x.Deleted).HasDefaultValue(false);
            //CreatedDate 
            builder.Property(x => x.DateCreated).ValueGeneratedOnAdd().IsRequired();
            //Updated Date
            builder.Property(x => x.DateUpdated).ValueGeneratedOnUpdate();
            builder.HasQueryFilter(x => x.Deleted == false);
        }
    }
}
