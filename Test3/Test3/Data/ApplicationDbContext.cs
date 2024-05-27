using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Test3.Models;

namespace Test3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Test3.Models.Product> Product { get; set; } = default!;
        public DbSet<Test3.Models.Order> Order { get; set; } = default!;
        public DbSet<Test3.Models.OrderItems> OrderItems { get; set; } = default!;

    }
}
