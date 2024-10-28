
using System.ComponentModel.DataAnnotations;
using Tozaroq.Infrastructure.Models.Base;

namespace Tozaroq.Infrastructure.Models
{
    public class IdentityUser : BaseEntity
    {
        [Required]
        public string PhoneNumber { get; set; }
        public bool IsPhoneNumberVerified { get; set; } = false;

        [Required]
        public string Password { get; set; }
    }
}
