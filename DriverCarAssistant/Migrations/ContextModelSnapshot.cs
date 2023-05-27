﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using databases_for_driver_car.DBContext;

#nullable disable

namespace DriverCarAssistant.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("databases_for_driver_car.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ExtinguisherDateOfExpiry")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("InsuranceDateOfExpiry")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("InsuranceDateOfIssue")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LPacketDateOfExpiry")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LPacketDateOfIssue")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LicenseDateOfExpiry")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LicenseDateOfIssue")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("MaintenanceDateOfExpiry")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("MaintenanceDateOfIssue")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nubmer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Service")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TachoСalibrationDateOfExpiry")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TachoСalibrationDateOfIssue")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("databases_for_driver_car.Models.Driver", b =>
                {
                    b.Property<int>("DriverId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Code95DateOfExpiry")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Code95DateOfIssue")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PESEL")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TachoKardDateOfExpiry")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TachoKardDateOfIssue")
                        .HasColumnType("TEXT");

                    b.HasKey("DriverId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("databases_for_driver_car.Models.DrivingLicense", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfExpiry")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DrivingLicense");
                });

            modelBuilder.Entity("databases_for_driver_car.Models.Passport", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfExpiry")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("TEXT");

                    b.Property<string>("PassportNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Passport");
                });

            modelBuilder.Entity("databases_for_driver_car.Models.Trailer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ExtinguisherDateOfExpiry")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("InsuranceDateOfExpiry")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("InsuranceDateOfIssue")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nubmer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Trailers");
                });

            modelBuilder.Entity("databases_for_driver_car.Models.Visa", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfExpiry")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("TEXT");

                    b.Property<string>("VisaNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Visa");
                });

            modelBuilder.Entity("databases_for_driver_car.Models.DrivingLicense", b =>
                {
                    b.HasOne("databases_for_driver_car.Models.Driver", "Driver")
                        .WithOne("DrivingLicense")
                        .HasForeignKey("databases_for_driver_car.Models.DrivingLicense", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("databases_for_driver_car.Models.Passport", b =>
                {
                    b.HasOne("databases_for_driver_car.Models.Driver", "Driver")
                        .WithOne("Passport")
                        .HasForeignKey("databases_for_driver_car.Models.Passport", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("databases_for_driver_car.Models.Visa", b =>
                {
                    b.HasOne("databases_for_driver_car.Models.Driver", "Driver")
                        .WithOne("Visa")
                        .HasForeignKey("databases_for_driver_car.Models.Visa", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("databases_for_driver_car.Models.Driver", b =>
                {
                    b.Navigation("DrivingLicense")
                        .IsRequired();

                    b.Navigation("Passport")
                        .IsRequired();

                    b.Navigation("Visa");
                });
#pragma warning restore 612, 618
        }
    }
}