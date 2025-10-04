using gchs.cos.entities.common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gchs.cos.context.mssql.Configurations.common
{
    public class ContactInfoTypeConfiguration : NamedEntityConfigurations<ContactInfoType>
    {
        public override void Configure(EntityTypeBuilder<ContactInfoType> builder)
        {
            builder.ToTable("ContactInfoTypes", "Common");
            builder.HasData(new List<ContactInfoType>
            {
                new () { Id = 1, Name = "Primary Email", LookupCode = "PRIMARYEMAIL", ExternalId = "PRIMARYEMAIL", Sequence = 2 },
                new () { Id = 1, Name = "Email", LookupCode = "EMAIL", ExternalId = "EMAIL" },
                new () { Id = 2, Name = "Primary Phone", LookupCode = "PRIMARYPHONE", ExternalId = "PRIMARYPHONE", Sequence = 1 },
                new () { Id = 3, Name = "Phone", LookupCode = "PHONE", ExternalId = "PHONE" },
                new () { Id = 4, Name = "Fax", LookupCode = "FAX", ExternalId = "FAX" },
                new () { Id = 5, Name = "Mobile Phone", LookupCode = "MOBILEPHONE", ExternalId = "MOBILEPHONE", Sequence = 3 },
                new () { Id = 5, Name = "Home Phone", LookupCode = "HOMEPHONE", ExternalId = "HOMEPHONE" },
                new () { Id = 5, Name = "Office Phone", LookupCode = "OFFICEPHONE", ExternalId = "OFFICEPHONE", Sequence = 4 }
            });
            base.Configure(builder);
        }
    }
}
