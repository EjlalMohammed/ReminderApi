using Domain.Entity;
using Domain.IRepository;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(ReminderDbContext dbContext) : base(dbContext)
        {
        }
    }
}
