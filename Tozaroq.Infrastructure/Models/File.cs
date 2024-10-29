using System.ComponentModel.DataAnnotations.Schema;
using Tozaroq.Infrastructure.Models.Base;

namespace Tozaroq.Infrastructure.Models
{
    public class File : BaseEntity
    {
        public byte[] Content { get; set; }
        public string Name { get;set; }
        public string Path { get; set; }

        public Guid AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public User Author { get; set; }

        public long Size { get; set; }
    }
}
