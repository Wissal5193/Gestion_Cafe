using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using projet.Models;

namespace projet.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<projet.Models.Cafe> Cafe { get; set; } = default!;
        public DbSet<projet.Models.Produit> Produits { get; set; }
    }
}
