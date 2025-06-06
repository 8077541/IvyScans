﻿// <auto-generated />
using System;
using IvyScans.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IvyScans.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IvyScans.API.Models.Chapter", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ComicId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ComicId");

                    b.ToTable("Chapters");
                });

            modelBuilder.Entity("IvyScans.API.Models.ChapterImage", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChapterId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChapterId");

                    b.ToTable("ChapterImages");
                });

            modelBuilder.Entity("IvyScans.API.Models.Comic", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cover")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Released")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Comics");
                });

            modelBuilder.Entity("IvyScans.API.Models.ComicGenre", b =>
                {
                    b.Property<string>("ComicId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GenreId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ComicId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("ComicGenres");
                });

            modelBuilder.Entity("IvyScans.API.Models.Genre", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("IvyScans.API.Models.ReadingHistory", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChapterId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ChapterNumber")
                        .HasColumnType("int");

                    b.Property<string>("ComicId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("LastReadAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ChapterId");

                    b.HasIndex("ComicId");

                    b.HasIndex("UserId");

                    b.ToTable("ReadingHistories");
                });

            modelBuilder.Entity("IvyScans.API.Models.RefreshToken", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("IvyScans.API.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("IvyScans.API.Models.UserBookmark", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ComicId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ComicId");

                    b.HasIndex("UserId");

                    b.ToTable("UserBookmarks");
                });

            modelBuilder.Entity("IvyScans.API.Models.UserRating", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ComicId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ComicId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRatings");
                });

            modelBuilder.Entity("IvyScans.API.Models.Chapter", b =>
                {
                    b.HasOne("IvyScans.API.Models.Comic", "Comic")
                        .WithMany("Chapters")
                        .HasForeignKey("ComicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comic");
                });

            modelBuilder.Entity("IvyScans.API.Models.ChapterImage", b =>
                {
                    b.HasOne("IvyScans.API.Models.Chapter", "Chapter")
                        .WithMany("Images")
                        .HasForeignKey("ChapterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chapter");
                });

            modelBuilder.Entity("IvyScans.API.Models.ComicGenre", b =>
                {
                    b.HasOne("IvyScans.API.Models.Comic", "Comic")
                        .WithMany("ComicGenres")
                        .HasForeignKey("ComicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IvyScans.API.Models.Genre", "Genre")
                        .WithMany("ComicGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comic");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("IvyScans.API.Models.ReadingHistory", b =>
                {
                    b.HasOne("IvyScans.API.Models.Chapter", "Chapter")
                        .WithMany("ReadingHistories")
                        .HasForeignKey("ChapterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IvyScans.API.Models.Comic", "Comic")
                        .WithMany("ReadingHistories")
                        .HasForeignKey("ComicId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("IvyScans.API.Models.User", "User")
                        .WithMany("ReadingHistories")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chapter");

                    b.Navigation("Comic");

                    b.Navigation("User");
                });

            modelBuilder.Entity("IvyScans.API.Models.RefreshToken", b =>
                {
                    b.HasOne("IvyScans.API.Models.User", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("IvyScans.API.Models.UserBookmark", b =>
                {
                    b.HasOne("IvyScans.API.Models.Comic", "Comic")
                        .WithMany("Bookmarks")
                        .HasForeignKey("ComicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IvyScans.API.Models.User", "User")
                        .WithMany("Bookmarks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comic");

                    b.Navigation("User");
                });

            modelBuilder.Entity("IvyScans.API.Models.UserRating", b =>
                {
                    b.HasOne("IvyScans.API.Models.Comic", "Comic")
                        .WithMany("Ratings")
                        .HasForeignKey("ComicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IvyScans.API.Models.User", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comic");

                    b.Navigation("User");
                });

            modelBuilder.Entity("IvyScans.API.Models.Chapter", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("ReadingHistories");
                });

            modelBuilder.Entity("IvyScans.API.Models.Comic", b =>
                {
                    b.Navigation("Bookmarks");

                    b.Navigation("Chapters");

                    b.Navigation("ComicGenres");

                    b.Navigation("Ratings");

                    b.Navigation("ReadingHistories");
                });

            modelBuilder.Entity("IvyScans.API.Models.Genre", b =>
                {
                    b.Navigation("ComicGenres");
                });

            modelBuilder.Entity("IvyScans.API.Models.User", b =>
                {
                    b.Navigation("Bookmarks");

                    b.Navigation("Ratings");

                    b.Navigation("ReadingHistories");

                    b.Navigation("RefreshTokens");
                });
#pragma warning restore 612, 618
        }
    }
}
