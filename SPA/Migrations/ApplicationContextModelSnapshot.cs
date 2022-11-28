﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SPA.Data;

#nullable disable

namespace SPA.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("SPA.Models.Award", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int?>("TutorId")
                        .HasColumnType("integer");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TutorId");

                    b.ToTable("Awards");
                });

            modelBuilder.Entity("SPA.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int?>("StudentId")
                        .HasColumnType("integer");

                    b.Property<int?>("TutorId")
                        .HasColumnType("integer");

                    b.Property<byte>("Type")
                        .HasColumnType("smallint");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TutorId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("SPA.Models.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("BeginYear")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("GraduationYear")
                        .HasColumnType("integer");

                    b.Property<int?>("TutorId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TutorId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("SPA.Models.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<bool>("Confirmed")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("StudentId")
                        .HasColumnType("integer");

                    b.Property<int?>("TutorId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TutorId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("SPA.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Rating")
                        .HasColumnType("double precision");

                    b.Property<int?>("StudentId")
                        .HasColumnType("integer");

                    b.Property<int?>("TutorId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TutorId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("SPA.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Avatar")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SPA.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int?>("TutorId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TutorId");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("SPA.Models.Tutor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Avatar")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("JobPlace")
                        .HasColumnType("text");

                    b.Property<string>("JobPost")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Rating")
                        .HasColumnType("double precision");

                    b.Property<string>("Requirements")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tutors");
                });

            modelBuilder.Entity("SPA.Models.Award", b =>
                {
                    b.HasOne("SPA.Models.Tutor", null)
                        .WithMany("Awards")
                        .HasForeignKey("TutorId");
                });

            modelBuilder.Entity("SPA.Models.Contact", b =>
                {
                    b.HasOne("SPA.Models.Student", null)
                        .WithMany("Contacts")
                        .HasForeignKey("StudentId");

                    b.HasOne("SPA.Models.Tutor", null)
                        .WithMany("Contacts")
                        .HasForeignKey("TutorId");
                });

            modelBuilder.Entity("SPA.Models.Education", b =>
                {
                    b.HasOne("SPA.Models.Tutor", null)
                        .WithMany("Educations")
                        .HasForeignKey("TutorId");
                });

            modelBuilder.Entity("SPA.Models.Lesson", b =>
                {
                    b.HasOne("SPA.Models.Student", null)
                        .WithMany("Lessons")
                        .HasForeignKey("StudentId");

                    b.HasOne("SPA.Models.Tutor", null)
                        .WithMany("Lessons")
                        .HasForeignKey("TutorId");
                });

            modelBuilder.Entity("SPA.Models.Review", b =>
                {
                    b.HasOne("SPA.Models.Student", null)
                        .WithMany("Reviews")
                        .HasForeignKey("StudentId");

                    b.HasOne("SPA.Models.Tutor", null)
                        .WithMany("Reviews")
                        .HasForeignKey("TutorId");
                });

            modelBuilder.Entity("SPA.Models.Subject", b =>
                {
                    b.HasOne("SPA.Models.Tutor", null)
                        .WithMany("Subjects")
                        .HasForeignKey("TutorId");
                });

            modelBuilder.Entity("SPA.Models.Student", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("Lessons");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("SPA.Models.Tutor", b =>
                {
                    b.Navigation("Awards");

                    b.Navigation("Contacts");

                    b.Navigation("Educations");

                    b.Navigation("Lessons");

                    b.Navigation("Reviews");

                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
