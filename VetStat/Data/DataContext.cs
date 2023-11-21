using Microsoft.EntityFrameworkCore;
using VetStat.Models;
using System.Collections;

namespace VetStat.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { 
        


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region one-to-oneRealationships
            //[Entity]-Person
            //Customer-Person
            modelBuilder.Entity<Customer>()     
            .HasOne(s => s.Person)             
            .WithMany()                         
            .HasForeignKey(e => e.Id)           
            .IsRequired(false);   
            
            //Nurse-Person
            modelBuilder.Entity<Nurse>()
            .HasOne(s => s.Person)
            .WithMany()
            .HasForeignKey(e => e.Id)
            .IsRequired(false);

            //Barber-Person
            modelBuilder.Entity<Barber>()
            .HasOne(s => s.Person)
            .WithMany()
            .HasForeignKey(e => e.Id)
            .IsRequired(false);

            //Vet-Person
            modelBuilder.Entity<Vet>()
            .HasOne(s => s.Person)
            .WithMany()
            .HasForeignKey(e => e.Id)
            .IsRequired(false);

            //////////////////////////
            //[Entity]-Employee
            //Nurse-Employee
            modelBuilder.Entity<Nurse>()
            .HasOne(s => s.Employee)
            .WithMany()
            .HasForeignKey(e => e.Id)
            .IsRequired(false);

            //Barber-Employee
            modelBuilder.Entity<Barber>()
            .HasOne(s => s.Employee)
            .WithMany()
            .HasForeignKey(e => e.Id)
            .IsRequired(false);

            //Vet-Employee
            modelBuilder.Entity<Vet>()
            .HasOne(s => s.Employee)
            .WithMany()
            .HasForeignKey(e => e.Id)
            .IsRequired(false);

            #endregion

            base.OnModelCreating(modelBuilder);
        } 
       public DbSet<Person> Person =>  Set<Person>();

       public DbSet<Customer> Customer => Set<Customer>();

       public DbSet<Nurse> Nurse => Set<Nurse>();

       public DbSet<Vet> Vet => Set<Vet>();

       public DbSet<Employee> Employee => Set<Employee>();

       public DbSet<Role> Role => Set<Role>();  
    }
}
