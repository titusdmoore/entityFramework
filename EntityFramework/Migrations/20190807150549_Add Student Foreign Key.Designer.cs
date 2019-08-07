﻿// <auto-generated />
using System;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFramework.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190807150549_Add Student Foreign Key")]
    partial class AddStudentForeignKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityFramework.Models.Major", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("MinSat");

                    b.HasKey("Id");

                    b.ToTable("Majors");
                });

            modelBuilder.Entity("EntityFramework.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("GPA");

                    b.Property<int?>("MajorId");

                    b.Property<int>("SAT");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<bool>("isFullTime");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("MajorId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EntityFramework.Models.Student", b =>
                {
                    b.HasOne("EntityFramework.Models.Major", "Major")
                        .WithMany()
                        .HasForeignKey("MajorId");
                });
#pragma warning restore 612, 618
        }
    }
}
