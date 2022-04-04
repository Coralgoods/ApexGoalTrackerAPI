﻿// <auto-generated />
using System;
using ApexGoalTrackerAPI.DataObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApexGoalTrackerAPI.Migrations
{
    [DbContext(typeof(ApexContext))]
    [Migration("20220403222107_Apex-database")]
    partial class Apexdatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApexGoalTrackerAPI.DataObjects.CurrentStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApexID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("RankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RankSore")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("banner")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserName");

                    b.ToTable("currentStats");
                });

            modelBuilder.Entity("ApexGoalTrackerAPI.DataObjects.User", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApexID")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("UserName");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ApexGoalTrackerAPI.DataObjects.UserGoal", b =>
                {
                    b.Property<string>("ApexID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RankScore")
                        .HasColumnType("int");

                    b.HasKey("ApexID");

                    b.ToTable("userGoals");
                });

            modelBuilder.Entity("ApexGoalTrackerAPI.DataObjects.CurrentStats", b =>
                {
                    b.HasOne("ApexGoalTrackerAPI.DataObjects.User", "User")
                        .WithMany()
                        .HasForeignKey("UserName");
                });

            modelBuilder.Entity("ApexGoalTrackerAPI.DataObjects.UserGoal", b =>
                {
                    b.HasOne("ApexGoalTrackerAPI.DataObjects.User", "User")
                        .WithMany()
                        .HasForeignKey("ApexID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}