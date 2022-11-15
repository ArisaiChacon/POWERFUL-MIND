using Microsoft.EntityFrameworkCore;
using PowerfulMind.Models;

namespace PowerfulMind.Data;
public class DataContext: DbContext
{
    public DataContext(DbContextOptions<DataContext> options): base (options) {

    }   
    protected override void OnModelCreating(ModelBuilder builder){
        // builder.Entity<Psicologo>()
        //      .HasOne(e => e.)
        //     .WithMany(e => e.Books)
        //      .IsRequired(false);

        // builder.Entity<Book>()
        //     .HasOne(e => e.Editorial)
        //     .WithMany(e => e.Books)
        //     .IsRequired(false);

        // builder.Entity<User>()
        //     .HasMany(e => e.Prestamos)
        //     .WithOne(e => e.User)
        //     .IsRequired(false);       
    }



    public DbSet<Paciente> Pacientes { get; set; } = default!;
    public DbSet<Psicologo> Psicologos { get; set; } = default!;
    public DbSet<Test> Tests { get; set; } = default!;
    public DbSet<Diagnostico> Diagnosticos { get; set; } = default!;

}