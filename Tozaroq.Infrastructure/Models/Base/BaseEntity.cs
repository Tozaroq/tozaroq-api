using System.ComponentModel.DataAnnotations;

namespace Tozaroq.Infrastructure.Models.Base
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; private set; } = Guid.NewGuid();

        [Required]
        public DateTime CreatedDate { get; private set; } = DateTime.UtcNow;

        public DateTime? LastModifiedDate { get; private set; }

        public void Update() 
        {
            LastModifiedDate = DateTime.UtcNow;
        }
    }
}
