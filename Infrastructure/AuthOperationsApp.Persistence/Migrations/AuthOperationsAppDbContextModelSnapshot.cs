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
                            Id = new Guid("2538688c-3339-428c-8197-dab8e3d8842b"),
                            Name = "Mağaza müdürleri grubu"
                        },
                        new
                        {
                            Id = new Guid("a00eb1f5-a62f-4be6-ad58-9d910f6f2948"),
                            Name = "Satış müdürleri grubu"
                        },
                        new
                        {
                            Id = new Guid("73335711-f124-418c-95bf-107bdfca4d90"),
                            Name = "IK çalışanları grubu"
                        },
                        new
                        {
                            Id = new Guid("03be5560-b263-43d2-ab28-0206b58098f1"),
                            Name = "Raporlama grubu"
                        },
                        new
                        {
                            Id = new Guid("449f4f14-ffb6-4ff7-ab32-93d0fb430602"),
                            Name = "IT destek grubu"
                        },
                        new
                        {
                            Id = new Guid("02c551e4-d201-41ce-ba11-98c218d91bcf"),
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
                            Id = new Guid("9e70e434-e56f-4679-8d80-f471c914ddb4"),
                            Name = "Taleplerim sayfasına girme yetkisi"
                        },
                        new
                        {
                            Id = new Guid("679dddf8-37e9-4012-9f8b-e0c5ebb747b8"),
                            Name = "Satışlarım sayfasına girme yetkisi"
                        },
                        new
                        {
                            Id = new Guid("c2d99a10-0427-4afc-8300-246b985128ec"),
                            Name = "Dashboard yetkisi"
                        },
                        new
                        {
                            Id = new Guid("8da091a4-959f-4a89-aca9-fd50d6c4a836"),
                            Name = "Taleplerim yetkisi"
                        },
                        new
                        {
                            Id = new Guid("23e2e4b5-415f-4087-afea-4c36bfa02dec"),
                            Name = "Wallboard yetkisi"
                        },
                        new
                        {
                            Id = new Guid("5c9c718f-61fa-4d5b-8924-7d5a8e559df5"),
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
