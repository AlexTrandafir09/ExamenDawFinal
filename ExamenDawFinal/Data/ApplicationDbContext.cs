using ExamenDawFinal.Model.Comanda;
using ExamenDawFinal.Model.Comanda_Produs;
using ExamenDawFinal.Model.Produs;
using ExamenDawFinal.Model.Utilizator;
using Microsoft.EntityFrameworkCore;
namespace ExamenDawFinal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<comanda> Comanda { get; set; }
        public DbSet<comanda_produs> Comanda_Produs { get; set; }
        public DbSet<produs> Produs { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<utilizator>()
                .HasMany(e => e.Comenzi)
                .WithOne(e => e.Utilizator)
                .HasForeignKey(e => e.Id)
                .IsRequired();

            modelBuilder.Entity<comanda_produs>()
                .HasOne(p => p.Comanda)
                .WithMany(p => p.Comanda_Produs)
                .HasForeignKey(p => p.Comanda.Id);

            modelBuilder.Entity<comanda_produs>()
                .HasOne(p => p.Produs)
                .WithMany(p => p.Comanda_Produs)
                .HasForeignKey(p => p.Produs.Id);
        }
    }
}
