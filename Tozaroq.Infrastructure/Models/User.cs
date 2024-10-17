using System.ComponentModel.DataAnnotations.Schema;
using Tozaroq.Infrastructure.Models.Base;

namespace Tozaroq.Infrastructure.Models
{
    public class User : PersistentEntity
    {
        public Guid IdentityUserId { get; set; }

        [ForeignKey(nameof(IdentityUserId))]
        public IdentityUser IdentityUser { get; set; }

        public string FirstName { get; set; }   
        public string LastName { get; set; }
    }
}
