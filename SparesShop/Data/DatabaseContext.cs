using SparesShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace SparesShop.Data
{
    public class DatabaseContext : IdentityDbContext<User>
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShopCartItem> ShopCartItem { get; set; }
        public DbSet<OrderDone> OrderDone { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetails> OrderDetail { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "{0471BC25-0981-4F79-B6FC-DF48D8097ED5}",
                Name = "admin",
                NormalizedName = "ADMIN"
            });
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "{0E68D371-5957-4482-9F86-98EE1AE139FB}",
                Name = "user",
                NormalizedName = "USER"
            });

            builder.Entity<User>().HasData(new User
            {
                Id = "{9876E46A-69E2-4B48-9BC5-DF16B7BDF26B}",
                UserName = "alvion2045@mail.ru",
                NormalizedUserName = "ALVION2045@MAIL.RU",
                Email = "alvion2045@mail.ru",
                NormalizedEmail = "ALVION2045@MAIL.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Admin1234"),
                SecurityStamp = string.Empty
            });
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "{0471BC25-0981-4F79-B6FC-DF48D8097ED5}",
                UserId = "{9876E46A-69E2-4B48-9BC5-DF16B7BDF26B}"
            });

        }
    }
}

