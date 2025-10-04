using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AppForSEII2526.API.Models;

namespace AppForSEII2526.API.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options) {

    protected override void OnModelCreating(ModelBuilder builder)
    {

        base.OnModelCreating(builder);

        builder.Entity<Genre>().HasAlternateKey(g => g.Name);
    }


    public DbSet<Genre> Genres { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Rental> Rentals { get; set; }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }

}
