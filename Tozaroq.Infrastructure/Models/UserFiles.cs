using System.ComponentModel.DataAnnotations.Schema;
using Tozaroq.Infrastructure.Models.Base;

namespace Tozaroq.Infrastructure.Models
{
    public class UserFiles : BaseEntity
    {
        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User Author { get; set; }

        public Guid FileId { get; set; }

        [ForeignKey(nameof(FileId))]
        public File File { get; set; }
    }
}
