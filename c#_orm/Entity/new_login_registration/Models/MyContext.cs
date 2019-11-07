using Microsoft.EntityFrameworkCore;

namespace new_login_registration.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options){}
        public DbSet<User> Users {get;set;}
        public DbSet<LoginUser> LoginUser {get;set;}
    }
}