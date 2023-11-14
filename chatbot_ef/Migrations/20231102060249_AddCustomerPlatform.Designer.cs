﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using chatbot_ef.Data;

#nullable disable

namespace chatbot_ef.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231102060249_AddCustomerPlatform")]
    partial class AddCustomerPlatform
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("chatbot_ef.Models.Appoinment", b =>
                {
                    b.Property<int>("Appointment_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Customer_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Appointment_ID");

                    b.HasIndex("Customer_ID");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("chatbot_ef.Models.Customer", b =>
                {
                    b.Property<int>("Customer_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ContactNumber")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("Platform_ID")
                        .HasColumnType("int");

                    b.Property<int>("Platform_ID1")
                        .HasColumnType("int");

                    b.HasKey("Customer_ID");

                    b.HasIndex("Platform_ID1");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("chatbot_ef.Models.CustomerPlatform", b =>
                {
                    b.Property<int>("CustomerPlatform_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Customer_ID")
                        .HasColumnType("int");

                    b.Property<int>("Platform_ID")
                        .HasColumnType("int");

                    b.HasKey("CustomerPlatform_ID");

                    b.HasIndex("Customer_ID");

                    b.HasIndex("Platform_ID");

                    b.ToTable("CustomerPlatform");
                });

            modelBuilder.Entity("chatbot_ef.Models.Platform", b =>
                {
                    b.Property<int>("Platform_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Platform_ID");

                    b.ToTable("Platforms");
                });

            modelBuilder.Entity("chatbot_ef.Models.Appoinment", b =>
                {
                    b.HasOne("chatbot_ef.Models.Customer", "Customer")
                        .WithMany("Appointments")
                        .HasForeignKey("Customer_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("chatbot_ef.Models.Customer", b =>
                {
                    b.HasOne("chatbot_ef.Models.Platform", "Platform")
                        .WithMany()
                        .HasForeignKey("Platform_ID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Platform");
                });

            modelBuilder.Entity("chatbot_ef.Models.CustomerPlatform", b =>
                {
                    b.HasOne("chatbot_ef.Models.Customer", "Customer")
                        .WithMany("CustomerPlatforms")
                        .HasForeignKey("Customer_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("chatbot_ef.Models.Platform", "Platform")
                        .WithMany("CustomerPlatforms")
                        .HasForeignKey("Platform_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Platform");
                });

            modelBuilder.Entity("chatbot_ef.Models.Customer", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("CustomerPlatforms");
                });

            modelBuilder.Entity("chatbot_ef.Models.Platform", b =>
                {
                    b.Navigation("CustomerPlatforms");
                });
#pragma warning restore 612, 618
        }
    }
}