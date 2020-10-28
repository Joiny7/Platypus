﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Officemancer;

namespace Officemancer.Migrations
{
    [DbContext(typeof(MancerContext))]
    [Migration("20201028140709_Remove_Mancers_from_Reservation")]
    partial class Remove_Mancers_from_Reservation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Officemancer.Models.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("CompanyID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Officemancer.Models.Floor", b =>
                {
                    b.Property<int>("FloorID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Bookable");

                    b.Property<int>("CurrentCapacity");

                    b.Property<string>("FloorName");

                    b.Property<int>("MaxCapacity");

                    b.Property<int>("OfficeID");

                    b.HasKey("FloorID");

                    b.HasIndex("OfficeID");

                    b.ToTable("Floors");
                });

            modelBuilder.Entity("Officemancer.Models.MiniLogin", b =>
                {
                    b.Property<int>("MiniLoginID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password");

                    b.Property<int>("UserID");

                    b.Property<string>("UserName");

                    b.HasKey("MiniLoginID");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("Officemancer.Models.Office", b =>
                {
                    b.Property<int>("OfficeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BannerMessage");

                    b.Property<int>("CompanyID");

                    b.Property<int>("CurrentCapacity");

                    b.Property<string>("OfficeName");

                    b.Property<int>("TotalCapacity");

                    b.HasKey("OfficeID");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("Officemancer.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookerID");

                    b.Property<DateTime>("Date");

                    b.Property<int>("FloorID");

                    b.Property<int>("OfficeID");

                    b.HasKey("ReservationID");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Officemancer.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Admin");

                    b.Property<int>("CompanyID");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("UserName");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Officemancer.Models.UserReservation", b =>
                {
                    b.Property<int>("UserReservationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ReservationID");

                    b.Property<DateTime>("Timestamp");

                    b.Property<int>("UserID");

                    b.HasKey("UserReservationID");

                    b.ToTable("UserReservations");
                });

            modelBuilder.Entity("Officemancer.Models.Warning", b =>
                {
                    b.Property<int>("WarningID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyID");

                    b.Property<string>("Message");

                    b.Property<int?>("OfficeID");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("WarningID");

                    b.ToTable("Warnings");
                });

            modelBuilder.Entity("Officemancer.Models.Floor", b =>
                {
                    b.HasOne("Officemancer.Models.Office")
                        .WithMany("Floors")
                        .HasForeignKey("OfficeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
