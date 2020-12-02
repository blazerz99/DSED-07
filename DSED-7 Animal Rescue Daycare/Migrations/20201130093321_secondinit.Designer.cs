﻿// <auto-generated />
using System;
using DSED_06_AdoptAPet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DSED_06_AdoptAPet.Migrations
{
    [DbContext(typeof(UserDbContext))]
    [Migration("20201130093321_secondinit")]
    partial class secondinit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10");

            modelBuilder.Entity("DSED_06_AdoptAPet.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("DogIDFK")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserIDFK")
                        .HasColumnType("INTEGER");

                    b.HasKey("AppointmentID");

                    b.HasIndex("DogIDFK");

                    b.HasIndex("UserIDFK");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("DSED_06_AdoptAPet.Models.Dogs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Age")
                        .HasColumnType("TEXT");

                    b.Property<string>("Breed")
                        .HasColumnType("TEXT");

                    b.Property<string>("DogName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EnteredShelter")
                        .HasColumnType("TEXT");

                    b.Property<string>("Illness")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Dogs");
                });

            modelBuilder.Entity("DSED_06_AdoptAPet.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("DSED_06_AdoptAPet.Models.Appointment", b =>
                {
                    b.HasOne("DSED_06_AdoptAPet.Models.Dogs", "Dogs")
                        .WithMany()
                        .HasForeignKey("DogIDFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DSED_06_AdoptAPet.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserIDFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
