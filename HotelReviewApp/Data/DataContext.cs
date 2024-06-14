using HotelReviewApp.Models;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Country> Countries { get; set; }
    public DbSet<Owner> Owners { get; set; }
    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<HotelOwner> HotelOwners { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Reviewer> Reviewers { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<HotelCategory> HotelCategories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HotelOwner>()
            .HasKey(po => new { po.HotelId, po.OwnerId });
        modelBuilder.Entity<HotelOwner>()
            .HasOne(p => p.Hotel)
            .WithMany(pc => pc.HotelOwners)
            .HasForeignKey(c => c.HotelId);
        modelBuilder.Entity<HotelOwner>()
            .HasOne(p => p.Owner)
            .WithMany(pc => pc.HotelOwners)
            .HasForeignKey(c => c.OwnerId);
    }
}
