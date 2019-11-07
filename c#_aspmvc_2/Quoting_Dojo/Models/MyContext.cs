using Microsoft.EntityFrameworkCore;

namespace Quoting_Dojo.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}
        public DbSet<Quoting> Quotings {get;set;}
    }
}