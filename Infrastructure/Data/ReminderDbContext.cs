using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ReminderDbContext : DbContext
    {
        public ReminderDbContext() { }
        public ReminderDbContext(DbContextOptions<ReminderDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // If using an inherited DbContext

            // Apply the default value for CreatedAt globally
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {

                var createdAtProperty = entityType.FindProperty("CreatedAt");
                if (createdAtProperty != null)
                {
                    createdAtProperty.SetDefaultValueSql("GETDATE()");
                }
            }
        }
    }
}
