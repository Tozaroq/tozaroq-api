using System.ComponentModel.DataAnnotations.Schema;
using Tozaroq.Infrastructure.Enums.UserFiles;
using Tozaroq.Infrastructure.Models.Base;

namespace Tozaroq.Infrastructure.Models
{
    public class UserFile : PersistentEntity
    {
        public Guid AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public User Author { get; set; }

        public Guid FileId { get; set; }

        [ForeignKey(nameof(FileId))]
        public File File { get; set; }

        public int Sequence { get; set; }

        public UserFileType Type { get; set; }
    }
}
