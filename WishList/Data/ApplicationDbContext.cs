using Microsoft.EntityFrameworkCore;

namespace WishList.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

    using WishList.Models;
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Models.Item> Items { get; set; }
    }
}
