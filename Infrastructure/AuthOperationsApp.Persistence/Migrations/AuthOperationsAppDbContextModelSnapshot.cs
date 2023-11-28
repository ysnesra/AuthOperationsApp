﻿// <auto-generated />
using System;
using AuthOperationsApp.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AuthOperationsApp.Persistence.Migrations
{
    [DbContext(typeof(AuthOperationsAppDbContext))]
    partial class AuthOperationsAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AuthOperationsApp.Domain.Entities.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = new Guid("52005372-470f-4b15-8876-f61b72691841"),
                            Name = "Mağaza müdürleri grubu"
                        },
                        new
                        {
                            Id = new Guid("53005372-470f-4b15-8876-f61b72691842"),
                            Name = "Satış müdürleri grubu"
                        },
                        new
                        {
                            Id = new Guid("54905372-470f-4b15-8876-f61b72691843"),
                            Name = "IK çalışanları grubu"
                        },
                        new
                        {
                            Id = new Guid("55805372-470f-4b15-8876-f61b72691844"),
                            Name = "Raporlama grubu"
                        },
                        new
                        {
                            Id = new Guid("56005372-470f-4b15-8876-f61b72691842"),
                            Name = "IT destek grubu"
                        },
                        new
                        {
                            Id = new Guid("27105372-470f-4b15-8876-f61b72691841"),
                            Name = "Eğitim destek grubu"
                        });
                });

            modelBuilder.Entity("AuthOperationsApp.Domain.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("22905372-470f-4b15-8876-f61b72691841"),
                            Name = "Taleplerim sayfasına girme yetki"
                        },
                        new
                        {
                            Id = new Guid("23905372-470f-4b15-8876-f61b72691842"),
                            Name = "Satışlarım sayfasına girme yetkisi"
                        },
                        new
                        {
                            Id = new Guid("24905372-470f-4b15-8876-f61b72691843"),
                            Name = "Dashboard yetkisi"
                        },
                        new
                        {
                            Id = new Guid("25905372-470f-4b15-8876-f61b72691844"),
                            Name = "Wallboard yetkisi"
                        },
                        new
                        {
                            Id = new Guid("26005372-470f-4b15-8876-f61b72691842"),
                            Name = "Wallboard yetkisi"
                        },
                        new
                        {
                            Id = new Guid("27105372-470f-4b15-8876-f61b72691841"),
                            Name = "İlanlarım yetkisi"
                        });
                });

            modelBuilder.Entity("AuthOperationsApp.Domain.Entities.RoleGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RoleGroups");
                });

            modelBuilder.Entity("AuthOperationsApp.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("72305372-470f-4b15-8876-f61b72691841"),
                            Email = "esra@gmail.com",
                            FullName = "Esra Yaşın",
                            Password = "Esra.1",
                            Phone = "05331545547",
                            UserName = "esra"
                        },
                        new
                        {
                            Id = new Guid("73305372-470f-4b15-8876-f61b72691843"),
                            Email = "mehmet@gmail.com",
                            FullName = "Mehmet Kutlu",
                            Password = "Mehmet.1",
                            Phone = "05551545547",
                            UserName = "mehmet"
                        },
                        new
                        {
                            Id = new Guid("74605372-470f-4b15-8876-f61b72691846"),
                            Email = "aysel@gmail.com",
                            FullName = "Aysel Aydınlık",
                            Password = "Aysel.1",
                            Phone = "05351545343",
                            UserName = "aysel"
                        },
                        new
                        {
                            Id = new Guid("75005372-470f-4b15-8876-f61b72691849"),
                            Email = "melek@gmail.com",
                            FullName = "Melek Mutlu",
                            Password = "Melek.1",
                            Phone = "05651547343",
                            UserName = "melek"
                        });
                });

            modelBuilder.Entity("AuthOperationsApp.Domain.Entities.UserGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserGroups");
                });
#pragma warning restore 612, 618
        }
    }
}
