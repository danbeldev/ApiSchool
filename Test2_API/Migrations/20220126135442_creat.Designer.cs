﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test2_API.database;

namespace Test2_API.Migrations
{
    [DbContext(typeof(EfModel))]
    [Migration("20220126135442_creat")]
    partial class creat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("SchooApi.model.Achievement", b =>
                {
                    b.Property<int>("AchievementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AchievementDescription")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("AchievementName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("AchievementId");

                    b.HasIndex("StudentId");

                    b.ToTable("Achievement");
                });

            modelBuilder.Entity("SchooApi.model.Director", b =>
                {
                    b.Property<int>("DirectorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DirectorDescription")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("DirectorName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.HasKey("DirectorId");

                    b.ToTable("Director");
                });

            modelBuilder.Entity("SchooApi.model.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("SchoolId")
                        .HasColumnType("int");

                    b.Property<string>("StudentDescription")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<int>("StudentSemester")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("SchoolId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("SchooApi.model.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<bool>("SubjectExam")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("SubjectId");

                    b.HasIndex("StudentId");

                    b.ToTable("subjects");
                });

            modelBuilder.Entity("SchooApi.model.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("SchoolId")
                        .HasColumnType("int");

                    b.Property<string>("TeacherDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TeacherName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TeacherId");

                    b.HasIndex("SchoolId");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("Test2_API.model.Auth.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FIO")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("user");
                });

            modelBuilder.Entity("Test2_API.model.Grade", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("GradeDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("GradeName")
                        .HasColumnType("int");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("GradeId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("Test2_API.model.School", b =>
                {
                    b.Property<int>("SchoolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DirectorId")
                        .HasColumnType("int");

                    b.Property<string>("SchoolDescription")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<double>("SchoolMapOne")
                        .HasColumnType("double");

                    b.Property<double>("SchoolMapTwo")
                        .HasColumnType("double");

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.HasKey("SchoolId");

                    b.HasIndex("DirectorId");

                    b.ToTable("schools");
                });

            modelBuilder.Entity("SchooApi.model.Achievement", b =>
                {
                    b.HasOne("SchooApi.model.Student", null)
                        .WithMany("Achievements")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("SchooApi.model.Student", b =>
                {
                    b.HasOne("Test2_API.model.School", null)
                        .WithMany("Students")
                        .HasForeignKey("SchoolId");
                });

            modelBuilder.Entity("SchooApi.model.Subject", b =>
                {
                    b.HasOne("SchooApi.model.Student", null)
                        .WithMany("Subjects")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("SchooApi.model.Teacher", b =>
                {
                    b.HasOne("Test2_API.model.School", null)
                        .WithMany("Teachers")
                        .HasForeignKey("SchoolId");
                });

            modelBuilder.Entity("Test2_API.model.Grade", b =>
                {
                    b.HasOne("SchooApi.model.Subject", null)
                        .WithMany("Grades")
                        .HasForeignKey("SubjectId");
                });

            modelBuilder.Entity("Test2_API.model.School", b =>
                {
                    b.HasOne("SchooApi.model.Director", "Director")
                        .WithMany()
                        .HasForeignKey("DirectorId");

                    b.Navigation("Director");
                });

            modelBuilder.Entity("SchooApi.model.Student", b =>
                {
                    b.Navigation("Achievements");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("SchooApi.model.Subject", b =>
                {
                    b.Navigation("Grades");
                });

            modelBuilder.Entity("Test2_API.model.School", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
