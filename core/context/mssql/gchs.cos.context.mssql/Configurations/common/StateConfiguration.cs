using gchs.cos.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gchs.cos.context.mssql.Configurations.common
{
    public class StateConfiguration : NamedEntityConfigurations<State>
    {
        public override void Configure(EntityTypeBuilder<State> builder)
        {
            builder.ToTable("States", "Common");

            builder.HasData(new List<State>
            {
                new () { Id = 1, Name = "Alabama", LookupCode = "AL", ExternalId = "AL" },
                new () { Id = 2, Name = "Alaska", LookupCode = "AK", ExternalId = "AK" },
                new () { Id = 3, Name = "Arizona", LookupCode = "AZ", ExternalId = "AZ" },
                new () { Id = 4, Name = "Arkansas", LookupCode = "AR", ExternalId = "AR" },
                new () { Id = 5, Name = "California", LookupCode = "CA", ExternalId = "CA" },
                new () { Id = 6, Name = "Canal Zone", LookupCode = "CZ", ExternalId = "CZ" },
                new () { Id = 7, Name = "Colorado", LookupCode = "CO", ExternalId = "CO" },
                new () { Id = 8, Name = "Connecticut", LookupCode = "CT", ExternalId = "CT" },
                new () { Id = 9, Name = "Delaware", LookupCode = "DE", ExternalId = "DE" },
                new () { Id = 10, Name = "District of Columbia", LookupCode = "DC", ExternalId = "DC" },
                new () { Id = 11, Name = "Florida", LookupCode = "FL", ExternalId = "FL" },
                new () { Id = 12, Name = "Georgia", LookupCode = "GA", ExternalId = "GA" },
                new () { Id = 13, Name = "Guam", LookupCode = "GU", ExternalId = "GU" },
                new () { Id = 14, Name = "Hawaii", LookupCode = "HI", ExternalId = "HI" },
                new () { Id = 15, Name = "Idaho", LookupCode = "ID", ExternalId = "ID" },
                new () { Id = 16, Name = "Illinois", LookupCode = "IL", ExternalId = "IL" },
                new () { Id = 17, Name = "Indiana", LookupCode = "IN", ExternalId = "IN" },
                new () { Id = 18, Name = "Iowa", LookupCode = "IA", ExternalId = "IA" },
                new () { Id = 19, Name = "Kansas", LookupCode = "KS", ExternalId = "KS" },
                new () { Id = 20, Name = "Kentucky", LookupCode = "KY", ExternalId = "KY" },
                new () { Id = 21, Name = "Louisiana", LookupCode = "LA", ExternalId = "LA" },
                new () { Id = 22, Name = "Maine", LookupCode = "ME", ExternalId = "ME" },
                new () { Id = 23, Name = "Maryland", LookupCode = "MD", ExternalId = "MD" },
                new () { Id = 24, Name = "Massachusetts", LookupCode = "MA", ExternalId = "MA" },
                new () { Id = 25, Name = "Michigan", LookupCode = "MI", ExternalId = "MI" },
                new () { Id = 26, Name = "Minnesota", LookupCode = "MN", ExternalId = "MN" },
                new () { Id = 27, Name = "Mississippi", LookupCode = "MS", ExternalId = "MS" },
                new () { Id = 28, Name = "Missouri", LookupCode = "MO", ExternalId = "MO" },
                new () { Id = 29, Name = "Montana", LookupCode = "MT", ExternalId = "MT" },
                new () { Id = 30, Name = "Nebraska", LookupCode = "NE", ExternalId = "NE" },
                new () { Id = 31, Name = "Nevada", LookupCode = "NV", ExternalId = "NV" },
                new () { Id = 32, Name = "New Hampshire", LookupCode = "NH", ExternalId = "NH" },
                new () { Id = 33, Name = "New Jersey", LookupCode = "NJ", ExternalId = "NJ" },
                new () { Id = 34, Name = "New Mexico", LookupCode = "NM", ExternalId = "NM" },
                new () { Id = 35, Name = "New York", LookupCode = "NY", ExternalId = "NY" },
                new () { Id = 36, Name = "North Carolina", LookupCode = "NC", ExternalId = "NC" },
                new () { Id = 37, Name = "North Dakota", LookupCode = "ND", ExternalId = "ND" },
                new () { Id = 38, Name = "Ohio", LookupCode = "OH", ExternalId = "OH" },
                new () { Id = 39, Name = "Oklahoma", LookupCode = "OK", ExternalId = "OK" },
                new () { Id = 40, Name = "Oregon", LookupCode = "OR", ExternalId = "OR" },
                new () { Id = 41, Name = "Pennsylvania", LookupCode = "PA", ExternalId = "PA" },
                new () { Id = 42, Name = "Puerto Rico", LookupCode = "PR", ExternalId = "PR" },
                new () { Id = 43, Name = "Rhode Island", LookupCode = "RI", ExternalId = "RI" },
                new () { Id = 44, Name = "South Carolina", LookupCode = "SC", ExternalId = "SC" },
                new () { Id = 45, Name = "South Dakota", LookupCode = "SD", ExternalId = "SD" },
                new () { Id = 46, Name = "Tennessee", LookupCode = "TN", ExternalId = "TN" },
                new () { Id = 47, Name = "Texas", LookupCode = "TX", ExternalId = "TX" },
                new () { Id = 48, Name = "Utah", LookupCode = "UT", ExternalId = "UT" },
                new () { Id = 49, Name = "Vermont", LookupCode = "VT", ExternalId = "VT" },
                new () { Id = 50, Name = "Virgin Islands", LookupCode = "VI", ExternalId = "VI" },
                new () { Id = 51, Name = "Virginia", LookupCode = "VA", ExternalId = "VA" },
                new () { Id = 52, Name = "Washington", LookupCode = "WA", ExternalId = "WA" },
                new () { Id = 53, Name = "West Virginia", LookupCode = "WV", ExternalId = "WV" },
                new () { Id = 54, Name = "Wisconsin", LookupCode = "WI", ExternalId = "WI" },
                new () { Id = 55, Name = "Wyoming", LookupCode = "WY", ExternalId = "WY" }
            });
            base.Configure(builder);
        }
    }
}
