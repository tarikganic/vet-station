﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VetStat.Data;

#nullable disable

namespace VetStat.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VetStat.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admin", (string)null);
                });

            modelBuilder.Entity("VetStat.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AnimalSpeciesId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("MedicalFile")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("AnimalSpeciesId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Animal", (string)null);
                });

            modelBuilder.Entity("VetStat.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AnimalId")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("TimeSlotId")
                        .HasColumnType("int");

                    b.Property<int?>("VetStationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TimeSlotId");

                    b.HasIndex("VetStationId");

                    b.ToTable("Appointment", (string)null);
                });

            modelBuilder.Entity("VetStat.Models.AuthentificationToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("IpAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LoggTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserProfileId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserProfileId");

                    b.ToTable("AuthentificationToken", (string)null);
                });

            modelBuilder.Entity("VetStat.Models.Availability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AppointmentDuration")
                        .HasColumnType("int");

                    b.Property<DateTime>("AvailableFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("AvailableTo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Availability", (string)null);
                });

            modelBuilder.Entity("VetStat.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("VetStat.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Continent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("City", (string)null);
                });

            modelBuilder.Entity("VetStat.Models.FAQ", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VetStationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VetStationId");

                    b.ToTable("FAQ", (string)null);
                });

            modelBuilder.Entity("VetStat.Models.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfEntry")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ProductionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<float>("SellingPrice")
                        .HasColumnType("real");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VetStationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("VetStationId");

                    b.ToTable("Inventory", (string)null);
                });

            modelBuilder.Entity("VetStat.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("RoleId");

                    b.ToTable("Person", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("VetStat.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SideEffects")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("VetStat.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("VetStat.Models.Species", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Behavior")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PredatorsAndThreats")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScientificName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpeciesName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Species", (string)null);
                });

            modelBuilder.Entity("VetStat.Models.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("SubCategory", (string)null);
                });

            modelBuilder.Entity("VetStat.Models.TimeSlot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AvailabilityId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<DateTime>("SlotDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SlotEmployeeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AvailabilityId");

                    b.HasIndex("SlotEmployeeId");

                    b.ToTable("TimeSlot", (string)null);
                });

            modelBuilder.Entity("VetStat.Models.VetStation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInOffice")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnField")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Parking")
                        .HasColumnType("bit");

                    b.Property<bool>("Wheelchair")
                        .HasColumnType("bit");

                    b.Property<bool>("Wifi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("VetStation", (string)null);
                });

            modelBuilder.Entity("VetStat.Models.Customer", b =>
                {
                    b.HasBaseType("VetStat.Models.Person");

                    b.Property<float?>("MembershipLoyalty")
                        .HasColumnType("real");

                    b.Property<DateTime>("ProfileCreationDate")
                        .HasColumnType("datetime2");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("VetStat.Models.Employee", b =>
                {
                    b.HasBaseType("VetStat.Models.Person");

                    b.Property<DateTime>("DateOfEmployment")
                        .HasColumnType("datetime2");

                    b.Property<int?>("VetStationId")
                        .HasColumnType("int");

                    b.HasIndex("VetStationId");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("VetStat.Models.Barber", b =>
                {
                    b.HasBaseType("VetStat.Models.Employee");

                    b.Property<byte[]>("Certification")
                        .HasColumnType("varbinary(max)");

                    b.ToTable("Barber", (string)null);
                });

            modelBuilder.Entity("VetStat.Models.Nurse", b =>
                {
                    b.HasBaseType("VetStat.Models.Employee");

                    b.Property<string>("Informations")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualifications")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Nurse", (string)null);
                });

            modelBuilder.Entity("VetStat.Models.Vet", b =>
                {
                    b.HasBaseType("VetStat.Models.Employee");

                    b.Property<string>("Education")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecialSkill")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speciality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Vet", (string)null);
                });

            modelBuilder.Entity("VetStat.Models.MainVet", b =>
                {
                    b.HasBaseType("VetStat.Models.Vet");

                    b.Property<int>("ChiefVetStationId")
                        .HasColumnType("int");

                    b.HasIndex("ChiefVetStationId");

                    b.ToTable("MainVet", (string)null);
                });

            modelBuilder.Entity("VetStat.Models.Animal", b =>
                {
                    b.HasOne("VetStat.Models.Species", "Species")
                        .WithMany()
                        .HasForeignKey("AnimalSpeciesId");

                    b.HasOne("VetStat.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("OwnerId");

                    b.Navigation("Customer");

                    b.Navigation("Species");
                });

            modelBuilder.Entity("VetStat.Models.Appointment", b =>
                {
                    b.HasOne("VetStat.Models.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId");

                    b.HasOne("VetStat.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("VetStat.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("VetStat.Models.TimeSlot", "TimeSlot")
                        .WithMany()
                        .HasForeignKey("TimeSlotId");

                    b.HasOne("VetStat.Models.VetStation", "VetStation")
                        .WithMany()
                        .HasForeignKey("VetStationId");

                    b.Navigation("Animal");

                    b.Navigation("Customer");

                    b.Navigation("Employee");

                    b.Navigation("TimeSlot");

                    b.Navigation("VetStation");
                });

            modelBuilder.Entity("VetStat.Models.AuthentificationToken", b =>
                {
                    b.HasOne("VetStat.Models.Person", "UserProfile")
                        .WithMany()
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("VetStat.Models.Availability", b =>
                {
                    b.HasOne("VetStat.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("VetStat.Models.FAQ", b =>
                {
                    b.HasOne("VetStat.Models.VetStation", "VetStation")
                        .WithMany()
                        .HasForeignKey("VetStationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VetStation");
                });

            modelBuilder.Entity("VetStat.Models.Inventory", b =>
                {
                    b.HasOne("VetStat.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VetStat.Models.VetStation", "VetStation")
                        .WithMany()
                        .HasForeignKey("VetStationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("VetStation");
                });

            modelBuilder.Entity("VetStat.Models.Person", b =>
                {
                    b.HasOne("VetStat.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("VetStat.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("City");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("VetStat.Models.SubCategory", b =>
                {
                    b.HasOne("VetStat.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VetStat.Models.Product", null)
                        .WithMany("SubCategories")
                        .HasForeignKey("ProductId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("VetStat.Models.TimeSlot", b =>
                {
                    b.HasOne("VetStat.Models.Availability", "Availability")
                        .WithMany()
                        .HasForeignKey("AvailabilityId");

                    b.HasOne("VetStat.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("SlotEmployeeId");

                    b.Navigation("Availability");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("VetStat.Models.VetStation", b =>
                {
                    b.HasOne("VetStat.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("VetStat.Models.MainVet", "MainVet")
                        .WithMany()
                        .HasForeignKey("MainVetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("MainVet");
                });

            modelBuilder.Entity("VetStat.Models.Customer", b =>
                {
                    b.HasOne("VetStat.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("VetStat.Models.Customer", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VetStat.Models.Employee", b =>
                {
                    b.HasOne("VetStat.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("Id");

                    b.HasOne("VetStat.Models.VetStation", "VetStation")
                        .WithMany("Employees")
                        .HasForeignKey("VetStationId");

                    b.Navigation("Person");

                    b.Navigation("VetStation");
                });

            modelBuilder.Entity("VetStat.Models.Barber", b =>
                {
                    b.HasOne("VetStat.Models.Employee", null)
                        .WithOne()
                        .HasForeignKey("VetStat.Models.Barber", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VetStat.Models.Nurse", b =>
                {
                    b.HasOne("VetStat.Models.Employee", null)
                        .WithOne()
                        .HasForeignKey("VetStat.Models.Nurse", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VetStat.Models.Vet", b =>
                {
                    b.HasOne("VetStat.Models.Employee", null)
                        .WithOne()
                        .HasForeignKey("VetStat.Models.Vet", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VetStat.Models.MainVet", b =>
                {
                    b.HasOne("VetStat.Models.VetStation", "ChiefVetStation")
                        .WithMany()
                        .HasForeignKey("ChiefVetStationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VetStat.Models.Vet", null)
                        .WithOne()
                        .HasForeignKey("VetStat.Models.MainVet", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChiefVetStation");
                });

            modelBuilder.Entity("VetStat.Models.Product", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("VetStat.Models.VetStation", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
