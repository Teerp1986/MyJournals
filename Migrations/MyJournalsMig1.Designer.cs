﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyJournalsAPI;

#nullable disable

namespace MyJournalsAPI.Migrations
{
    [DbContext(typeof(MyJournalDbContext))]
    [Migration("20230703162426_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("MyJournalsAPI.Models.Dietary", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("DietaryNotes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("JournalsId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("JournalsId");

                    b.ToTable("Dietary");
                });

            modelBuilder.Entity("MyJournalsAPI.Models.Health", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HealthIssue")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("JournalsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Physician")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("JournalsId");

                    b.ToTable("Health");
                });

            modelBuilder.Entity("MyJournalsAPI.Models.Journals", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Journals");
                });

            modelBuilder.Entity("MyJournalsAPI.Models.MealType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Breakfast")
                        .HasColumnType("TEXT");

                    b.Property<string>("Desert")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("DietaryId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Dinner")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lunch")
                        .HasColumnType("TEXT");

                    b.Property<string>("Snacks")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DietaryId");

                    b.ToTable("MealType");
                });

            modelBuilder.Entity("MyJournalsAPI.Models.Personal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("JournalEntry")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("JournalsId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("JournalsId");

                    b.ToTable("Personal");
                });

            modelBuilder.Entity("MyJournalsAPI.Models.Travel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("JournalsId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("JournalsId");

                    b.ToTable("Travel");
                });

            modelBuilder.Entity("MyJournalsAPI.Models.Dietary", b =>
                {
                    b.HasOne("MyJournalsAPI.Models.Journals", null)
                        .WithMany("Dietary")
                        .HasForeignKey("JournalsId");
                });

            modelBuilder.Entity("MyJournalsAPI.Models.Health", b =>
                {
                    b.HasOne("MyJournalsAPI.Models.Journals", null)
                        .WithMany("Health")
                        .HasForeignKey("JournalsId");
                });

            modelBuilder.Entity("MyJournalsAPI.Models.MealType", b =>
                {
                    b.HasOne("MyJournalsAPI.Models.Dietary", null)
                        .WithMany("MealType")
                        .HasForeignKey("DietaryId");
                });

            modelBuilder.Entity("MyJournalsAPI.Models.Personal", b =>
                {
                    b.HasOne("MyJournalsAPI.Models.Journals", null)
                        .WithMany("Personal")
                        .HasForeignKey("JournalsId");
                });

            modelBuilder.Entity("MyJournalsAPI.Models.Travel", b =>
                {
                    b.HasOne("MyJournalsAPI.Models.Journals", null)
                        .WithMany("Travel")
                        .HasForeignKey("JournalsId");
                });

            modelBuilder.Entity("MyJournalsAPI.Models.Dietary", b =>
                {
                    b.Navigation("MealType");
                });

            modelBuilder.Entity("MyJournalsAPI.Models.Journals", b =>
                {
                    b.Navigation("Dietary");

                    b.Navigation("Health");

                    b.Navigation("Personal");

                    b.Navigation("Travel");
                });
#pragma warning restore 612, 618
        }
    }
}
