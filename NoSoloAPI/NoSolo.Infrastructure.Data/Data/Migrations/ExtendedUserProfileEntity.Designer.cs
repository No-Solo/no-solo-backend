﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NoSolo.Infrastructure.Data.DbContext;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace NoSolo.Infrastructure.Data.Data.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20230831121405_ExtendedUserProfileEntity")]
    partial class ExtendedUserProfileEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("NoSolo.Core.Entities.ContactEntity<NoSolo.Core.Entities.UserProfile>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("TEntityId")
                        .HasColumnType("uuid");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("TEntityId");

                    b.ToTable("ContactEntity<UserProfile>");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.OrganizationEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.OrganizationOfferEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("uuid");

                    b.Property<int[]>("Tags")
                        .HasColumnType("integer[]");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("OrganizationOfferEntity");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.OrganizationPhotoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("IsMain")
                        .HasColumnType("boolean");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("uuid");

                    b.Property<string>("PublicId")
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("OrganizationPhotoEntity");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.OrganizationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("uuid");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("UserId");

                    b.ToTable("OrganizationUser");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId")
                        .IsUnique();

                    b.ToTable("Project");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.RefreshToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("TokenHash")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.RequestEntity<NoSolo.Core.Entities.OrganizationEntity, NoSolo.Core.Entities.UserOfferEntity>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<Guid>("TEntityId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UEntityId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("TEntityId");

                    b.HasIndex("UEntityId");

                    b.ToTable("RequestEntity<OrganizationEntity, UserOfferEntity>");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.RequestEntity<NoSolo.Core.Entities.UserProfile, NoSolo.Core.Entities.OrganizationOfferEntity>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<Guid>("TEntityId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UEntityId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("TEntityId");

                    b.HasIndex("UEntityId");

                    b.ToTable("RequestEntity<UserProfile, OrganizationOfferEntity>");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("NoSolo.Core.Entities.UserOfferEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Preferences")
                        .HasColumnType("text");

                    b.Property<Guid>("UserProfileId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserProfileId");

                    b.ToTable("UserOfferEntity");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.UserPhotoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("PublicId")
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.Property<Guid>("UserProfileId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserProfileId")
                        .IsUnique();

                    b.ToTable("UserPhotoEntity");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.UserProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("About")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<int>("Locale")
                        .HasColumnType("integer");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserProfile");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.UserTagEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("Tag")
                        .HasColumnType("integer");

                    b.Property<Guid>("UserProfileId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserProfileId");

                    b.ToTable("UserTagEntity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("NoSolo.Core.Entities.ContactEntity<NoSolo.Core.Entities.UserProfile>", b =>
                {
                    b.HasOne("NoSolo.Core.Entities.UserProfile", "TEntity")
                        .WithMany("Contacts")
                        .HasForeignKey("TEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TEntity");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.OrganizationOfferEntity", b =>
                {
                    b.HasOne("NoSolo.Core.Entities.OrganizationEntity", "OrganizationEntity")
                        .WithMany("Offers")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrganizationEntity");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.OrganizationPhotoEntity", b =>
                {
                    b.HasOne("NoSolo.Core.Entities.OrganizationEntity", "OrganizationEntity")
                        .WithMany("Photos")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrganizationEntity");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.OrganizationUser", b =>
                {
                    b.HasOne("NoSolo.Core.Entities.OrganizationEntity", "OrganizationEntity")
                        .WithMany("OrganizationUsers")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NoSolo.Core.Entities.UserEntity", "UserEntity")
                        .WithMany("OrganizationUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrganizationEntity");

                    b.Navigation("UserEntity");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.Project", b =>
                {
                    b.HasOne("NoSolo.Core.Entities.OrganizationEntity", "OrganizationEntity")
                        .WithOne("Project")
                        .HasForeignKey("NoSolo.Core.Entities.Project", "OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrganizationEntity");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.RefreshToken", b =>
                {
                    b.HasOne("NoSolo.Core.Entities.UserEntity", "UserEntity")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserEntity");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.RequestEntity<NoSolo.Core.Entities.OrganizationEntity, NoSolo.Core.Entities.UserOfferEntity>", b =>
                {
                    b.HasOne("NoSolo.Core.Entities.OrganizationEntity", "TEntity")
                        .WithMany("RequestsFromOrganizationToUserOffer")
                        .HasForeignKey("TEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NoSolo.Core.Entities.UserOfferEntity", "UEntity")
                        .WithMany()
                        .HasForeignKey("UEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TEntity");

                    b.Navigation("UEntity");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.RequestEntity<NoSolo.Core.Entities.UserProfile, NoSolo.Core.Entities.OrganizationOfferEntity>", b =>
                {
                    b.HasOne("NoSolo.Core.Entities.UserProfile", "TEntity")
                        .WithMany("RequestsFromUserProfileToOgranizationOffer")
                        .HasForeignKey("TEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NoSolo.Core.Entities.OrganizationOfferEntity", "UEntity")
                        .WithMany()
                        .HasForeignKey("UEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TEntity");

                    b.Navigation("UEntity");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.UserOfferEntity", b =>
                {
                    b.HasOne("NoSolo.Core.Entities.UserProfile", "UserProfile")
                        .WithMany("Offers")
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.UserPhotoEntity", b =>
                {
                    b.HasOne("NoSolo.Core.Entities.UserProfile", "UserProfile")
                        .WithOne("PhotoEntity")
                        .HasForeignKey("NoSolo.Core.Entities.UserPhotoEntity", "UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.UserProfile", b =>
                {
                    b.HasOne("NoSolo.Core.Entities.UserEntity", "UserEntity")
                        .WithOne("UserProfile")
                        .HasForeignKey("NoSolo.Core.Entities.UserProfile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserEntity");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.UserTagEntity", b =>
                {
                    b.HasOne("NoSolo.Core.Entities.UserProfile", "UserProfile")
                        .WithMany("Tags")
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("NoSolo.Core.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("NoSolo.Core.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NoSolo.Core.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("NoSolo.Core.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NoSolo.Core.Entities.OrganizationEntity", b =>
                {
                    b.Navigation("Offers");

                    b.Navigation("OrganizationUsers");

                    b.Navigation("Photos");

                    b.Navigation("Project");

                    b.Navigation("RequestsFromOrganizationToUserOffer");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.UserEntity", b =>
                {
                    b.Navigation("OrganizationUsers");

                    b.Navigation("RefreshTokens");

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("NoSolo.Core.Entities.UserProfile", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("Offers");

                    b.Navigation("PhotoEntity");

                    b.Navigation("RequestsFromUserProfileToOgranizationOffer");

                    b.Navigation("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}
