#nullable disable

namespace gchs.cos.entities
{
    public class Person : NamedEntity
    {
        public virtual ICollection<Name> Names { get; set; }
    }
}
