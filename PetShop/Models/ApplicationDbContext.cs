using Microsoft.EntityFrameworkCore;
namespace PetShop.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Order>()
            //   .HasOne(e => e.Customer)
            //   .WithOne(e => e.Order)
            //   .HasForeignKey<Customer>(e => e.OrderId)
            //   .IsRequired();

            //modelBuilder.Entity<Order>()
            // .HasOne(e => e.Shipment)
            // .WithOne(e => e.Order)
            // .HasForeignKey<Shipment>(e => e.OrderId)
            // .IsRequired();


            //modelBuilder.Entity<OrderItem>()
            //   .HasOne(e => e.Order)
            //   .WithMany(e => e.OrderItems)
            // .HasForeignKey(e =>e.OrderId)
            //   .IsRequired();


            //modelBuilder.Entity<Pet>()
            //  .HasOne(e => e.OrderItem)
            //  .WithMany(e => e.Pets)
            // .HasForeignKey(e => e.OrderItemId)
            //  .IsRequired();

            //modelBuilder.Entity<Pet>()
            // .HasOne(e => e.Category)
            // .WithMany(e => e.Pets)
            //.HasForeignKey(e => e.PetCategoryId)
            // .IsRequired();


        }
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Pet> pets => Set<Pet>();
        public DbSet<Order> orders => Set<Order>();
        public DbSet<OrderItem> orderItems => Set<OrderItem>();
        public DbSet<PetCategory> petCategories => Set<PetCategory>();
        public DbSet<Shipment> shipment => Set<Shipment>();
    }
}

