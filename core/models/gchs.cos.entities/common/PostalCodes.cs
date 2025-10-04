#nullable disable
namespace gchs.cos.entities
{
    public class PostalCodes : BaseEntity
    {
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string TimeZone { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int AreaCode { get; set; }
        public string County { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
