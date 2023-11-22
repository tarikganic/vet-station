using Microsoft.EntityFrameworkCore;
using VetStat.Models;
using System.Collections;
using System.Reflection.Metadata;

namespace VetStat.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vet>().ToTable("Vet");
            modelBuilder.Entity<Nurse>().ToTable("Nurse");
            modelBuilder.Entity<Barber>().ToTable("Barber");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Person>().ToTable("Person");

            modelBuilder.Entity<Employee>()
            .HasOne(s => s.Person)
            .WithMany()
            .HasForeignKey(e => e.Id)
            .IsRequired(false);

        }
        public DbSet<Person> Person => Set<Person>();
        public DbSet<Customer> Customer => Set<Customer>();

        public DbSet<Nurse> Nurse => Set<Nurse>();

        public DbSet<Vet> Vet => Set<Vet>();

        public DbSet<Employee> Employee => Set<Employee>();

        public DbSet<Role> Role => Set<Role>();

        public DbSet<Barber> Barber => Set<Barber>();
    }
}
