#nullable disable
namespace gchs.cos.entities
{
    public abstract class NamedEntity : BaseEntity
    {
        public string ExternalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LookupCode { get; set; }
        public int Sequence { get; set; } = 9999;
    }
}
