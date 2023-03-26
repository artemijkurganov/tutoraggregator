﻿// <auto-generated />
using System;
using EFCore.Postgres.Application.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EfCore.MigrationsTool.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230326081023_Test")]
    partial class Test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("EFCore.Postgres.Application.Models.Entities.AvatarEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.ToTable("Avatars");
                });

            modelBuilder.Entity("EFCore.Postgres.Application.Models.Entities.AwardEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("TutorEntityId")
                        .HasColumnType("uuid");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("TutorEntityId");

                    b.ToTable("Awards");
                });

            modelBuilder.Entity("EFCore.Postgres.Application.Models.Entities.EducationEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("TutorEntityId")
                        .HasColumnType("uuid");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("TutorEntityId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("EFCore.Postgres.Application.Models.Entities.LessonEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("End")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<DateTimeOffset>("Start")
                        .HasColumnType("timestamp with time zone");

                    b.Property<byte>("Status")
                        .HasColumnType("smallint");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TutorId")
                        .HasColumnType("uuid");

                    b.Property<byte>("Type")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TutorId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("EFCore.Postgres.Application.Models.Entities.LocationEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("EFCore.Postgres.Application.Models.Entities.RequirementEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("TutorEntityId")
                        .HasColumnType("uuid");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("TutorEntityId");

                    b.ToTable("Requirements");
                });

            modelBuilder.Entity("EFCore.Postgres.Application.Models.Entities.ReviewEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Rating")
                        .HasColumnType("double precision");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TutorId")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TutorId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("EFCore.Postgres.Application.Models.Entities.StudentContactEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("StudentEntityId")
                        .HasColumnType("uuid");

                    b.Property<byte>("Type")
                        .HasColumnType("smallint");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("StudentEntityId");

                    b.ToTable("StudentsContacts");
                });

            modelBuilder.Entity("EFCore.Postgres.Application.Models.Entities.StudentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int?>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("EducationPlace")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("Grade")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EFCore.Postgres.Application.Models.Entities.SubjectEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("EFCore.Postgres.Application.Models.Entities.TutorContactEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("TutorEntityId")
                        .HasColumnType("uuid");

                    b.Property<byte>("Type")
                        .HasColumnType("smallint");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("TutorEntityId");

                    b.ToTable("TutorsContacts");
                });

            modelBuilder.Entity("EFCore.Postgres.Application.Models.Entities.TutorEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Job")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("LocationId")
                        .HasColumnType("uuid");

                    b.Property<double>("Rating")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Tutors");
                });

            modelBuilder.Entity("SubjectEntityTutorEntity", b =>
                {
                    b.Property<Guid>("SubjectsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TutorsId")
                        .HasColumnType("uuid");

                    b.HasKey("SubjectsId", "TutorsId");

                    b.HasIndex("TutorsId");

                    b.ToTable("SubjectEntityTutorEntity");
                });

            modelBuilder.Entity("EFCore.Postgres.Application.Models.Entities.AwardEntity", b =>
                {
                    b.HasOne("EFCore.Postgres.Application.Models.Entities.TutorEntity", null)
                        .WithMany("Awards")
                        .HasForeignKey("TutorEntityId");
                });

            modelBuilder.Entity("EFCore.Postgres.Application.Models.Entities.EducationEntity", b =>
                {
                    b.HasOne("EFCore.Postgres.Application.Models.Entities.TutorEntity", null)
                        .WithMany("Educations")
                        .HasForeignKey("TutorEntityId");
                });

            modelBuilder.Entity("EFCore.Postgres.Application.Models.Entities.LessonEntity", b =>
                {
                    b.HasOne("EFCore.Postgres.Application.Models.Entities.StudentEntity", "Student")
                        .WithMany("Lessons")
                        .HasForeignKey("StudentId");

                    b.HasOne("EFCore.Postgres.Application.Models.Entities.TutorEntity", "Tutor")
                        .WithMany("Lessons")
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("EFCore.Postgres.Application.Models.Entities.RequirementEntity", b =>
                {
                    b.HasOne("EFCore.Postgres.Application.Models.Entities.TutorEntity", null)
                        .WithMany("Requirements")
                        .HasForeignKey("TutorEntityId");
                });

            modelBuilder.Entity("EFCore.Postgres.Application.Models.Entities.ReviewEntity", b =>
                {
                    b.HasOne("EFCore.Postgres.Application.Models.Entities.StudentEntity", "Student")
                        .WithMany("Reviews")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCore.Postgres.Application.Models.Entities.TutorEntity", "Tutor")
                        .WithMany("Reviews")
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("EFCore.Postgres.Application.Models.Entities.StudentContactEntity", b =>
                {
                    b.HasOne("EFCore.Postgres.Application.Models.Entities.StudentEntity", null)
                        .WithMany("Contacts")
                        .HasForeignKey("StudentEntityId");
                });

            modelBuilder.Entity("EFCore.Postgres.Application.Models.Entities.TutorContactEntity", b =>
                {
                    b.HasOne("EFCore.Postgres.Application.Models.Entities.TutorEntity", null)
                        .WithMany("Contacts")
                        .HasForeignKey("TutorEntityId");
                });

            modelBuilder.Entity("EFCore.Postgres.Application.Models.Entities.TutorEntity", b =>
                {
                    b.HasOne("EFCore.Postgres.Application.Models.Entities.LocationEntity", "Location")
                        .WithMany("Tutors")
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("SubjectEntityTutorEntity", b =>
                {
                    b.HasOne("EFCore.Postgres.Application.Models.Entities.SubjectEntity", null)
                        .WithMany()
                        .HasForeignKey("SubjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCore.Postgres.Application.Models.Entities.TutorEntity", null)
                        .WithMany()
                        .HasForeignKey("TutorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCore.Postgres.Application.Models.Entities.LocationEntity", b =>
                {
                    b.Navigation("Tutors");
                });

            modelBuilder.Entity("EFCore.Postgres.Application.Models.Entities.StudentEntity", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("Lessons");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("EFCore.Postgres.Application.Models.Entities.TutorEntity", b =>
                {
                    b.Navigation("Awards");

                    b.Navigation("Contacts");

                    b.Navigation("Educations");

                    b.Navigation("Lessons");

                    b.Navigation("Requirements");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
