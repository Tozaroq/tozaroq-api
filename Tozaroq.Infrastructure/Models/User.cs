using System.ComponentModel.DataAnnotations.Schema;
using Tozaroq.Infrastructure.Models.Base;

namespace Tozaroq.Infrastructure.Models
{
    public class User : PersistentEntity
    {
        /// <summary>
        /// When the User is deleted, IdentityUserId should be set to null
        /// </summary>
        public Guid? IdentityUserId { get; set; }

        [ForeignKey(nameof(IdentityUserId))]
        public IdentityUser IdentityUser { get; set; }

        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public string ProfileName { get; set; }
    }
}
