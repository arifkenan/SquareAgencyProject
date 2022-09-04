﻿// <auto-generated />
using System;
using KareAjans.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccountApplication.Migrations.Agency
{
    [DbContext(typeof(AgencyContext))]
    [Migration("20220827210852_initDb")]
    partial class initDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("KareAjans.Models.Contract", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ActorID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<int>("ManagingStaffID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("ActorID");

                    b.HasIndex("ManagingStaffID");

                    b.ToTable("Contract");
                });

            modelBuilder.Entity("KareAjans.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("KareAjans.Models.Actor", b =>
                {
                    b.HasBaseType("KareAjans.Models.Person");

                    b.Property<double>("ContractPrice")
                        .HasColumnType("float");

                    b.Property<int?>("ManagerID")
                        .HasColumnType("int");

                    b.HasIndex("ManagerID");

                    b.ToTable("Actor");
                });

            modelBuilder.Entity("KareAjans.Models.Staff", b =>
                {
                    b.HasBaseType("KareAjans.Models.Person");

                    b.Property<double>("PerformanceScore")
                        .HasColumnType("float");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("KareAjans.Models.Contract", b =>
                {
                    b.HasOne("KareAjans.Models.Actor", "Actor")
                        .WithMany("Contracts")
                        .HasForeignKey("ActorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KareAjans.Models.Staff", "ManagingStaff")
                        .WithMany("Contracts")
                        .HasForeignKey("ManagingStaffID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("ManagingStaff");
                });

            modelBuilder.Entity("KareAjans.Models.Actor", b =>
                {
                    b.HasOne("KareAjans.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("KareAjans.Models.Actor", "ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("KareAjans.Models.Staff", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerID");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("KareAjans.Models.Staff", b =>
                {
                    b.HasOne("KareAjans.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("KareAjans.Models.Staff", "ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KareAjans.Models.Actor", b =>
                {
                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("KareAjans.Models.Staff", b =>
                {
                    b.Navigation("Contracts");
                });
#pragma warning restore 612, 618
        }
    }
}
