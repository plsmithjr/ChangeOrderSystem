#nullable disable

namespace gchs.cos.entities
{
    public class Name : BaseEntity
    {
        public long PersonId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string Prefix { get; set; }
        public int Sequence { get; set; } = 9999;

        public virtual Person Person { get; set; }
    }
}
