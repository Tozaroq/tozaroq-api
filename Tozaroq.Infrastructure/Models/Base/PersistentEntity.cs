using System.ComponentModel.DataAnnotations;
using Tozaroq.Infrastructure.Enums.Base;

namespace Tozaroq.Infrastructure.Models.Base
{
    public abstract class PersistentEntity : BaseEntity
    {
        [Required]
        public EntityState State { get; set; } = EntityState.Active;
    }
}
