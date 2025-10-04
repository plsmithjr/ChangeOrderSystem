using gchs.cos.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gchs.cos.context.mssql.Configurations.crm
{
    public class PersonConfiguration : BaseEntityConfigurations<Person>
    {
        public override void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("People", "CRM");
            builder.HasMany(p => p.Names).WithOne(n => n.Person).HasForeignKey(n => n.PersonId).OnDelete(DeleteBehavior.Cascade);
            base.Configure(builder);
        }
    }
}
