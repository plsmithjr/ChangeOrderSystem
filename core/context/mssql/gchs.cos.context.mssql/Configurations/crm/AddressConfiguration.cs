using gchs.cos.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gchs.cos.context.mssql.Configurations.crm
{
    internal class AddressConfiguration : BaseEntityConfigurations<Person>
    {
        public override void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Addresses", "CRM");
            builder.HasOne(a => a.Person).WithMany(p => p.Addresses).HasForeignKey(a => a.PersonId).OnDelete(DeleteBehavior.Cascade);
            base.Configure(builder);
        }
    }
}
