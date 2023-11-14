using chatbot_ef.Models;
using Microsoft.EntityFrameworkCore;

namespace chatbot_ef.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Appoinment> Appointments { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ChatSession> ChatSessions { get; set; }
        public DbSet<ShopOwner> ShopOwners { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.Category_ID)
                .HasConstraintName("FK_Product_Category");

            modelBuilder.Entity<ChatMessage>()
                .HasOne(c => c.ChatSession)
                .WithMany(s => s.ChatMessages)
                .HasForeignKey(c => c.Session_ID)
                .HasConstraintName("FK_ChatMessage_ChatSession");

            modelBuilder.Entity<ChatMessage>()
                .HasOne(c => c.Platform)
                .WithMany(p => p.ChatMessages)
                .HasForeignKey(c => c.Platform_ID)
                .HasConstraintName("FK_ChatMessage_Platform");

            modelBuilder.Entity<Appoinment>()
                .HasOne(a => a.Shop)
                .WithMany(s => s.Appointments)
                .HasForeignKey(a => a.Shop_Id)
                .HasConstraintName("FK_Appointment_Shop");

            modelBuilder.Entity<Shop>()
                .HasOne(s => s.ShopOwner)
                .WithMany(so => so.Shops)
                .HasForeignKey(s => s.ShopOwner_ID)
                .HasConstraintName("FK_Shop_ShopOwner");

            // Configure many-to-many relationship between ChatSession and Shop using ChatSessionShop as the linking table
            modelBuilder.Entity<ChatSessionShop>()
                .HasKey(css => new { css.ChatSessionId, css.Shop_Id });

            modelBuilder.Entity<ChatSessionShop>()
                .HasOne(css => css.ChatSession)
                .WithMany(cs => cs.ChatSessionShops)
                .HasForeignKey(css => css.ChatSessionId);

            modelBuilder.Entity<ChatSessionShop>()
                .HasOne(css => css.Shop)
                .WithMany(s => s.ChatSessionShops)
                .HasForeignKey(css => css.Shop_Id);

            // Configure many-to-many relationship between Platform and Shop using ShopPlatform as the linking table
            modelBuilder.Entity<ShopPlatform>()
                .HasKey(sp => new { sp.ShopId, sp.PlatformId });

            modelBuilder.Entity<ShopPlatform>()
                .HasOne(sp => sp.Shop)
                .WithMany(s => s.ShopPlatforms)
                .HasForeignKey(sp => sp.ShopId);

            modelBuilder.Entity<ShopPlatform>()
                .HasOne(sp => sp.Platform)
                .WithMany(p => p.ShopPlatforms)
                .HasForeignKey(sp => sp.PlatformId);

            // Configure many-to-many relationship between Product and Shop using ShopProduct as the linking table
            modelBuilder.Entity<ShopProduct>()
            .HasKey(sp => new { sp.ShopId, sp.ProductId });

            modelBuilder.Entity<ShopProduct>()
                .HasOne(sp => sp.Shop)
                .WithMany(s => s.ShopProducts)
                .HasForeignKey(sp => sp.ShopId);

            modelBuilder.Entity<ShopProduct>()
                .HasOne(sp => sp.Product)
                .WithMany(p => p.ShopProducts)
                .HasForeignKey(sp => sp.ProductId);


            modelBuilder.Entity<ShopOwner>()
        .HasOne(so => so.ChatSession)
        .WithMany(cs => cs.ShopOwners)
        .HasForeignKey(so => so.ChatSessionId)
        .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<ChatSession>()
        .HasOne(cs => cs.Customer)
        .WithMany(c => c.ChatSessions)
        .HasForeignKey(cs => cs.CustomerId)
        .HasConstraintName("FK_ChatSession_Customer");
        }
    }
}
