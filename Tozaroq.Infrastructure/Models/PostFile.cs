using System.ComponentModel.DataAnnotations.Schema;
using Tozaroq.Infrastructure.Enums.UserFiles;
using Tozaroq.Infrastructure.Models.Base;

namespace Tozaroq.Infrastructure.Models
{
    public class PostFile : PersistentEntity
    {
        public Guid AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public User Author { get; set; }

        public Guid FileId { get; set; }

        [ForeignKey(nameof(FileId))]
        public File File { get; set; }

        public Guid PostId { get; set; }

        [ForeignKey(nameof(PostId))]
        public Post Post { get; set; }

        public int Sequnce { get; set; }   
        public PostFileType Type { get; set; }
    }
}
