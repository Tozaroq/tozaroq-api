using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tozaroq.Infrastructure.Models.Base;
using NetTopologySuite.Geometries;
using Tozaroq.Infrastructure.Enums.Posts;

namespace Tozaroq.Infrastructure.Models
{
    public class Post : PersistentEntity
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        public PostStatus Status { get; set; }

        public Guid AuthorId { get; set; }
        
        [ForeignKey(nameof(AuthorId))]
        public User Author { get; set; }

        [Required]
        public decimal Price { get; set; }
        public bool IsPriceNegotiable { get; set; } = false;
        
        public DateTime? Deadline { get; set; }

        [Required]
        public Point Location { get; set; }
    }
}
