using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Fav : IEntity
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
