
namespace Domain.Entity
{
    public class Role : BaseNameEntity
    {
        public ICollection<User> Users { get; set; }
    }
}
