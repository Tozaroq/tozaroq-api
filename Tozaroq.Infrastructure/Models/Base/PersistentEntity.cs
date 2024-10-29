using System.ComponentModel.DataAnnotations;
using Tozaroq.Infrastructure.Enums.Base;

namespace Tozaroq.Infrastructure.Models.Base
{
    /// <summary>
    /// implemented classes' objects are never removed from the database, regardless of the circumstances
    /// </summary>
    public abstract class PersistentEntity : BaseEntity
    {
        [Required]
        public EntityState State { get; private set; } = EntityState.Active;

        public void Delete() 
        {
            State = EntityState.Deleted;
            Update();
        }
    }
}
