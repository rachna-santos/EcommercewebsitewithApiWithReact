using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EcommercewebsitewithApi.Model
{
    public class MyDbContext : IdentityDbContext<ApplicationUser>
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<User> register { get; set; }
        public DbSet<Login> login { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<Product> product { get; set; }
        public DbSet<Category> category { get; set; }
        public DbSet<SubCategory> subCategories { get; set;}
        public DbSet<Cart> carts { get; set;}
        public DbSet<Cart_item> cart_Items { get; set;}
        public DbSet<Order> orders { get; set; }
        public DbSet<Order_Details> order_Details { get; set;}
        public DbSet<Brand> brands { get; set;}
        public DbSet<Color> colors { get; set;}
        public DbSet<Material> materials {get; set;}
        public DbSet<Size> sizes {get; set;}
        public DbSet<Gender> genders {get; set;}
        public DbSet<UserDetails> userDetails {get; set;}
        public DbSet<City> cities {get; set;}
        public DbSet<Country> countries { get; set;}
        public DbSet<CategoryStyle> categoryStyles { get; set; }
        public DbSet<ProductSeason> productSeasons { get; set; }
        public DbSet<Productveriation> productveriations { get; set; }
        public DbSet<ProductImage> productImages { get; set; }
        public DbSet<userCountry> userCountries { get; set; }
        public DbSet<UserCity> userCities { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<customerlogin> customerlogins { get; set; }
        public DbSet<ShoppingCart> shoppingCarts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
             modelBuilder.Entity<ApplicationUser>()
            .HasOne(s => s.Status)
            .WithMany(user => user.users)
            .HasForeignKey(s => s.StatusId)
            .IsRequired(false);

             modelBuilder.Entity<ApplicationUser>()
            .HasOne(s => s.Company)
            .WithMany(user => user.users)
            .HasForeignKey(s => s.CompanyId)
            .IsRequired(false);

             modelBuilder.Entity<ApplicationRole>()
            .HasOne(s => s.Status)
            .WithMany(user => user.Role)
            .HasForeignKey(s => s.StatusId)
            .IsRequired(false);

             modelBuilder.Entity<ApplicationRole>()
            .HasOne(s => s.Company)
            .WithMany(user => user.Role)
            .HasForeignKey(s => s.CompanyId)
            .IsRequired(false);

             modelBuilder.Entity<Order>()
            .HasOne(user =>user.applicationUser)
            .WithMany(o=>o.orders)
            .HasForeignKey(user => user.UserId)
            .IsRequired(false);

            modelBuilder.Entity<Cart>()
           .HasOne(user => user.ApplicationUser)
           .WithMany(o => o.cart)
           .HasForeignKey(user => user.UserId)
           .IsRequired(false);
        }
    }
}
