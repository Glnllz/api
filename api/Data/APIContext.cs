using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class APIContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        public APIContext(DbContextOptions<APIContext> options) : base(options)
        {
        }
    }
}
