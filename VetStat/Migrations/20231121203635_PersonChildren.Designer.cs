﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VetStat.Data;

#nullable disable

namespace VetStat.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231121203635_PersonChildren")]
    partial class PersonChildren
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VetStat.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Picture")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Person");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");

                    b.UseTphMappingStrategy();
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

                    b.ToTable("Role");
                });

            modelBuilder.Entity("VetStat.Models.Barber", b =>
                {
                    b.HasBaseType("VetStat.Models.Person");

                    b.Property<byte[]>("Certification")
                        .HasColumnType("varbinary(max)");

                    b.HasDiscriminator().HasValue("Barber");
                });

            modelBuilder.Entity("VetStat.Models.Customer", b =>
                {
                    b.HasBaseType("VetStat.Models.Person");

                    b.Property<float?>("MembershipLoyalty")
                        .HasColumnType("real");

                    b.Property<DateTime>("ProfileCreationDate")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("Customer");
                });

            modelBuilder.Entity("VetStat.Models.Employee", b =>
                {
                    b.HasBaseType("VetStat.Models.Person");

                    b.Property<DateTime>("DateOfEmployment")
                        .HasColumnType("datetime2");

                    b.Property<int>("VetstationId")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Employee");
                });

            modelBuilder.Entity("VetStat.Models.Nurse", b =>
                {
                    b.HasBaseType("VetStat.Models.Person");

                    b.Property<string>("Informations")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualifications")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Nurse");
                });

            modelBuilder.Entity("VetStat.Models.Vet", b =>
                {
                    b.HasBaseType("VetStat.Models.Person");

                    b.Property<string>("Education")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecialSkill")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speciality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Vet");
                });

            modelBuilder.Entity("VetStat.Models.Person", b =>
                {
                    b.HasOne("VetStat.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("VetStat.Models.Barber", b =>
                {
                    b.HasOne("VetStat.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("Id");

                    b.HasOne("VetStat.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("Id");

                    b.Navigation("Employee");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("VetStat.Models.Customer", b =>
                {
                    b.HasOne("VetStat.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("Id");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("VetStat.Models.Nurse", b =>
                {
                    b.HasOne("VetStat.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("Id");

                    b.HasOne("VetStat.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("Id");

                    b.Navigation("Employee");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("VetStat.Models.Vet", b =>
                {
                    b.HasOne("VetStat.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("Id");

                    b.HasOne("VetStat.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("Id");

                    b.Navigation("Employee");

                    b.Navigation("Person");
                });
#pragma warning restore 612, 618
        }
    }
}
