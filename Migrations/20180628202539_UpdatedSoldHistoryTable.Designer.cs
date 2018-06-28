﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NilamHutAPI.Data;

namespace NilamHutAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180628202539_UpdatedSoldHistoryTable")]
    partial class UpdatedSoldHistoryTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rc1-32029")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("NilamHutAPI.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("NilamHutAPI.Models.Bid", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId")
                        .IsRequired();

                    b.Property<int>("BidPrice");

                    b.Property<DateTime>("BidTime");

                    b.Property<Guid?>("ProductId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ProductId");

                    b.ToTable("Bid");
                });

            modelBuilder.Entity("NilamHutAPI.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("NilamHutAPI.Models.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("NilamHutAPI.Models.Credit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Credits");
                });

            modelBuilder.Entity("NilamHutAPI.Models.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImgPath")
                        .IsRequired();

                    b.Property<Guid>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("NilamHutAPI.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId")
                        .IsRequired();

                    b.Property<double>("BasePrice");

                    b.Property<Guid?>("CategoryId");

                    b.Property<Guid?>("CityId");

                    b.Property<string>("ContactInfo")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<DateTime?>("EndDateTime")
                        .IsRequired();

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Quantity")
                        .IsRequired();

                    b.Property<DateTime?>("StartDateTime")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CityId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("NilamHutAPI.Models.ProductTag", b =>
                {
                    b.Property<Guid>("ProductId");

                    b.Property<Guid>("TagId");

                    b.HasKey("ProductId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("ProductTags");
                });

            modelBuilder.Entity("NilamHutAPI.Models.Rating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId")
                        .IsRequired();

                    b.Property<string>("UserComment")
                        .HasMaxLength(500);

                    b.Property<int>("UserRating");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("NilamHutAPI.Models.SoldHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId")
                        .IsRequired();

                    b.Property<string>("BuyerID")
                        .IsRequired();

                    b.Property<DateTime?>("DateTime")
                        .IsRequired();

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("ProductID")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<double>("SoldPrice");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("UserId");

                    b.ToTable("SoldHistories");
                });

            modelBuilder.Entity("NilamHutAPI.Models.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TagDescription")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("NilamHutAPI.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(500);

                    b.Property<string>("ApplicationUserId")
                        .IsRequired();

                    b.Property<Guid>("CityId");

                    b.Property<string>("FullName")
                        .HasMaxLength(50);

                    b.Property<string>("Image");

                    b.Property<bool>("IsVip");

                    b.Property<string>("Phone")
                        .HasMaxLength(50);

                    b.Property<string>("PostCode")
                        .HasMaxLength(20);

                    b.Property<Guid?>("RatingId");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId")
                        .IsUnique();

                    b.HasIndex("CityId");

                    b.HasIndex("RatingId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("NilamHutAPI.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("NilamHutAPI.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NilamHutAPI.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("NilamHutAPI.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NilamHutAPI.Models.Bid", b =>
                {
                    b.HasOne("NilamHutAPI.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NilamHutAPI.Models.Product", "Products")
                        .WithMany("Bids")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NilamHutAPI.Models.Credit", b =>
                {
                    b.HasOne("NilamHutAPI.Models.User", "User")
                        .WithOne("Credit")
                        .HasForeignKey("NilamHutAPI.Models.Credit", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NilamHutAPI.Models.Image", b =>
                {
                    b.HasOne("NilamHutAPI.Models.Product", "Product")
                        .WithMany("Image")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NilamHutAPI.Models.Product", b =>
                {
                    b.HasOne("NilamHutAPI.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Products")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NilamHutAPI.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.HasOne("NilamHutAPI.Models.City", "City")
                        .WithMany("Products")
                        .HasForeignKey("CityId");
                });

            modelBuilder.Entity("NilamHutAPI.Models.ProductTag", b =>
                {
                    b.HasOne("NilamHutAPI.Models.Product", "Product")
                        .WithMany("Tags")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NilamHutAPI.Models.Tag", "Tag")
                        .WithMany("Products")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NilamHutAPI.Models.Rating", b =>
                {
                    b.HasOne("NilamHutAPI.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NilamHutAPI.Models.SoldHistory", b =>
                {
                    b.HasOne("NilamHutAPI.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("SoldHistories")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NilamHutAPI.Models.User")
                        .WithMany("SoldHistory")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("NilamHutAPI.Models.User", b =>
                {
                    b.HasOne("NilamHutAPI.Models.ApplicationUser", "ApplicationUser")
                        .WithOne("User")
                        .HasForeignKey("NilamHutAPI.Models.User", "ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NilamHutAPI.Models.City")
                        .WithMany("User")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NilamHutAPI.Models.Rating", "Rating")
                        .WithMany()
                        .HasForeignKey("RatingId");
                });
#pragma warning restore 612, 618
        }
    }
}
