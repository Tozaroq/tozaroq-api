using Tozaroq.Infrastructure.Models.Base;

namespace Tozaroq.Infrastructure.Models
{
    public class File : BaseEntity
    {
        public byte[] Content { get; set; }
        public string Name { get;set; }
    }
}
