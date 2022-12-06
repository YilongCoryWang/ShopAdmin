using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopAdmin.Models;

public class MvcProductContext : IdentityDbContext
    {
        public MvcProductContext (DbContextOptions<MvcProductContext> options)
            : base(options)
        {
        }

        public DbSet<ShopAdmin.Models.Product> Product { get; set; }
    }
