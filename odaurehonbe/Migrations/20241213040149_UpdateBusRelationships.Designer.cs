﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using odaurehonbe.Data;

#nullable disable

namespace odaurehonbe.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241213040149_UpdateBusRelationships")]
    partial class UpdateBusRelationships
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Customer", b =>
                {
                    b.Property<int>("AccountID")
                        .HasColumnType("integer");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AccountID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Driver", b =>
                {
                    b.Property<int>("AccountID")
                        .HasColumnType("integer");

                    b.Property<int?>("BusID")
                        .HasColumnType("integer");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LicenseNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AccountID");

                    b.HasIndex("BusID");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("TicketClerk", b =>
                {
                    b.Property<int>("AccountID")
                        .HasColumnType("integer");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("HireDate")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AccountID");

                    b.ToTable("TicketClerks");
                });

            modelBuilder.Entity("odaurehonbe.Data.Account", b =>
                {
                    b.Property<int>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AccountID"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AccountID");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("odaurehonbe.Data.Bus", b =>
                {
                    b.Property<int>("BusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BusID"));

                    b.Property<int>("NumSeat")
                        .HasColumnType("integer");

                    b.Property<string>("PlateNum")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("BusID");

                    b.ToTable("Buses");
                });

            modelBuilder.Entity("odaurehonbe.Data.BusRoute", b =>
                {
                    b.Property<int>("BusRouteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BusRouteID"));

                    b.Property<string>("ArrivalPlace")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("BusID")
                        .HasColumnType("integer");

                    b.Property<string>("DepartPlace")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.HasKey("BusRouteID");

                    b.HasIndex("BusID");

                    b.ToTable("BusRoutes");
                });

            modelBuilder.Entity("odaurehonbe.Data.Param", b =>
                {
                    b.Property<DateTime>("CancelDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("MaxPromo")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("PaymentTerm")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("RefundableDate")
                        .HasColumnType("timestamp with time zone");

                    b.ToTable("Params");
                });

            modelBuilder.Entity("odaurehonbe.Data.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PaymentID"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("integer");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("PaymentTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("PromoID")
                        .HasColumnType("integer");

                    b.Property<int>("StaffID")
                        .HasColumnType("integer");

                    b.Property<int>("TicketID")
                        .HasColumnType("integer");

                    b.Property<decimal>("TotalFee")
                        .HasColumnType("numeric");

                    b.HasKey("PaymentID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("odaurehonbe.Data.Promotion", b =>
                {
                    b.Property<int>("PromoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PromoID"));

                    b.Property<decimal>("Discount")
                        .HasColumnType("numeric");

                    b.Property<float>("DiscountPercent")
                        .HasColumnType("real");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("PromoID");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("odaurehonbe.Data.Ticket", b =>
                {
                    b.Property<int>("TicketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TicketID"));

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("BusID")
                        .HasColumnType("integer");

                    b.Property<int>("CustomerID")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("SeatNum")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("TicketID");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Customer", b =>
                {
                    b.HasOne("odaurehonbe.Data.Account", "Account")
                        .WithOne("Customer")
                        .HasForeignKey("Customer", "AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Driver", b =>
                {
                    b.HasOne("odaurehonbe.Data.Account", "Account")
                        .WithOne("Driver")
                        .HasForeignKey("Driver", "AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("odaurehonbe.Data.Bus", null)
                        .WithMany("Drivers")
                        .HasForeignKey("BusID");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("TicketClerk", b =>
                {
                    b.HasOne("odaurehonbe.Data.Account", "Account")
                        .WithOne("TicketClerk")
                        .HasForeignKey("TicketClerk", "AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("odaurehonbe.Data.BusRoute", b =>
                {
                    b.HasOne("odaurehonbe.Data.Bus", null)
                        .WithMany("BusRoutes")
                        .HasForeignKey("BusID");
                });

            modelBuilder.Entity("odaurehonbe.Data.Account", b =>
                {
                    b.Navigation("Customer")
                        .IsRequired();

                    b.Navigation("Driver")
                        .IsRequired();

                    b.Navigation("TicketClerk")
                        .IsRequired();
                });

            modelBuilder.Entity("odaurehonbe.Data.Bus", b =>
                {
                    b.Navigation("BusRoutes");

                    b.Navigation("Drivers");
                });
#pragma warning restore 612, 618
        }
    }
}