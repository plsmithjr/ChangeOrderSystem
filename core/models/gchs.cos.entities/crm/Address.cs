#nullable disable

namespace gchs.cos.entities
{
    public class Address : BaseEntity
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public long PostalCodeId { get; set; }
    }
}
