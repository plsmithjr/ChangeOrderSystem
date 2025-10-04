#nullable disable
namespace gchs.cos.entities
{
    public abstract class BaseEntity
    {
        public long Id { get; set; }
        public bool Active { get; set; } = true;
        public bool Deleted { get; set; } = false;
        public int Creator { get; set; } = 9999;
        public int? Updator { get; set; }
        public int? Deletor { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}
