using gchs.cos.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gchs.cos.context.mssql.Configurations.crm
{
    public class NameConfiguration : BaseEntityConfigurations<Name>
    {
        public override void Configure(EntityTypeBuilder<Name> builder)
        {
            builder.ToTable("Names", "CRM");
            builder.Property(x => x.FirstName).HasMaxLength(250);
            builder.Property(x => x.MiddleName).HasMaxLength(250);
            builder.Property(x => x.LastName).HasMaxLength(250);
            builder.Property(x => x.Suffix).HasMaxLength(250);
            builder.Property(x => x.Prefix).HasMaxLength(250);
            builder.Property(x => x.Sequence).HasDefaultValue(9999);
            builder.HasOne(n => n.Person).WithMany(p => p.Names).HasForeignKey(n => n.PersonId).OnDelete(DeleteBehavior.Cascade);
            base.Configure(builder);
        }
    }
}
