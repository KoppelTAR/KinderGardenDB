﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TARge20.Data;

namespace TARge20.Data.Migrations
{
    [DbContext(typeof(TARge20DbContext))]
    [Migration("20210914085021_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TARge20.Core.Domain.Child", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupHistory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentPhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Child");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Cook", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HistoryOfJobs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Cook");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Educator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HistoryOfJobs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Educator");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ChildId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EducatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GroupType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MethodologistId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NameOfGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SeniorEducatorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ChildId");

                    b.HasIndex("CookId");

                    b.HasIndex("EducatorId");

                    b.HasIndex("MethodologistId");

                    b.HasIndex("SeniorEducatorId")
                        .IsUnique()
                        .HasFilter("[SeniorEducatorId] IS NOT NULL");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("TARge20.Core.Domain.GroupQueue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ChildId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OpenGroups")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Slots")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChildId");

                    b.HasIndex("GroupId");

                    b.ToTable("GroupQueue");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Kindergarden", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kindergarden");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Kitchen", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("HistoryOfJobs")
                        .HasColumnType("int");

                    b.Property<Guid?>("MenuId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CookId");

                    b.HasIndex("MenuId");

                    b.ToTable("Kitchen");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Menu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DayOfServing")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Meal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Portion")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeOfMeal")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Methodologist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HistoryOfJobs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Methodologist");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Senior_Educator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HistoryOfJobs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("SeniorEducator");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Child", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Cook", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Educator", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Group", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Child", "Child")
                        .WithMany()
                        .HasForeignKey("ChildId");

                    b.HasOne("TARge20.Core.Domain.Cook", "Cook")
                        .WithMany()
                        .HasForeignKey("CookId");

                    b.HasOne("TARge20.Core.Domain.Educator", "Educator")
                        .WithMany()
                        .HasForeignKey("EducatorId");

                    b.HasOne("TARge20.Core.Domain.Methodologist", "Methodologist")
                        .WithMany()
                        .HasForeignKey("MethodologistId");

                    b.HasOne("TARge20.Core.Domain.Senior_Educator", "Senior_Educator")
                        .WithOne()
                        .HasForeignKey("TARge20.Core.Domain.Group", "SeniorEducatorId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.GroupQueue", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Child", "Child")
                        .WithMany()
                        .HasForeignKey("ChildId");

                    b.HasOne("TARge20.Core.Domain.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Kitchen", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Cook", "Cook")
                        .WithMany()
                        .HasForeignKey("CookId");

                    b.HasOne("TARge20.Core.Domain.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Menu", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Methodologist", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Senior_Educator", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId");
                });
#pragma warning restore 612, 618
        }
    }
}
