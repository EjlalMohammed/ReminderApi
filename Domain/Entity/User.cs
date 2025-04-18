
using System.Data;

namespace Domain.Entity
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Guid? RoleId { get; set; }
        public Role Role { get; set; }
    }
}
