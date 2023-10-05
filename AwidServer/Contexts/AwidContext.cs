using AwidServer.Models;
using Microsoft.EntityFrameworkCore;

namespace AwidServer.Contexts
{
    public class AwidContext : DbContext
    {
        public AwidContext(DbContextOptions<AwidContext> options) 
            :base(options)
        { }

        public DbSet<User> users { get; set; } = null;
        public DbSet<Product> products { get; set; } = null;

    }
}
