﻿// <auto-generated />
using System;
using EBiograf.Web.Api.Environment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ebiograf.Web.API.Migrations
{
    [DbContext(typeof(EBiografDbContext))]
    [Migration("20210912155050_productAdded1")]
    partial class productAdded1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EBiograf.Web.Api.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(76)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Bookings.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumberOfSeats")
                        .HasColumnType("int");

                    b.Property<int?>("ShowID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("BookingID");

                    b.HasIndex("ShowID");

                    b.HasIndex("UserID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Bookings.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal");

                    b.Property<int>("BookingID")
                        .HasColumnType("int");

                    b.Property<int>("DiscountCuponID")
                        .HasColumnType("int");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime");

                    b.HasKey("PaymentID");

                    b.HasIndex("BookingID")
                        .IsUnique();

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Cinema.Cinema", b =>
                {
                    b.Property<int>("CinemaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CinemaAddressID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("TotalCinemaHalls")
                        .HasColumnType("int");

                    b.HasKey("CinemaID");

                    b.HasIndex("CinemaAddressID")
                        .IsUnique();

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Cinema.CinemaAddress", b =>
                {
                    b.Property<int>("CinemaAdressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Address2")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("CinemaAdressID");

                    b.ToTable("CinemaAddresses");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Cinema.CinemaHall", b =>
                {
                    b.Property<int>("CinemaHallID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CinemaID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("TotalSeats")
                        .HasColumnType("int");

                    b.HasKey("CinemaHallID");

                    b.HasIndex("CinemaID");

                    b.ToTable("CinemaHalls");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Cinema.CinemaSeat", b =>
                {
                    b.Property<int>("CinemaSeatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CinemaHallID")
                        .HasColumnType("int");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.HasKey("CinemaSeatID");

                    b.HasIndex("CinemaHallID");

                    b.ToTable("CinemaSeats");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Movie.Genre", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(512)");

                    b.HasKey("GenreID");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Movie.GenreMovie", b =>
                {
                    b.Property<int>("GenresGenreID")
                        .HasColumnType("int");

                    b.Property<int>("MoviesMovieID")
                        .HasColumnType("int");

                    b.HasKey("GenresGenreID", "MoviesMovieID");

                    b.HasIndex("MoviesMovieID");

                    b.ToTable("GenreMovie");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Movie.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Censorship")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(512)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("ImgLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(16)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("TrailerLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MovieID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Show.Show", b =>
                {
                    b.Property<int>("ShowID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CinemaHallID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime");

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime");

                    b.HasKey("ShowID");

                    b.HasIndex("CinemaHallID")
                        .IsUnique()
                        .HasFilter("[CinemaHallID] IS NOT NULL");

                    b.HasIndex("MovieID");

                    b.ToTable("Shows");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Show.ShowSeat", b =>
                {
                    b.Property<int>("ShowSeatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookingID")
                        .HasColumnType("int");

                    b.Property<int>("CinemaSeatID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal");

                    b.Property<int>("ShowID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ShowSeatID");

                    b.HasIndex("BookingID");

                    b.HasIndex("CinemaSeatID");

                    b.HasIndex("ShowID");

                    b.ToTable("ShowSeats");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Snacks.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(512)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Snacks.Snack", b =>
                {
                    b.Property<int>("SnackID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookingID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("SnackID");

                    b.HasIndex("BookingID");

                    b.HasIndex("ProductID");

                    b.ToTable("Snacks");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Bookings.Booking", b =>
                {
                    b.HasOne("Ebiograf.Web.API.Models.Show.Show", null)
                        .WithMany("Booking")
                        .HasForeignKey("ShowID");

                    b.HasOne("EBiograf.Web.Api.Models.User", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Bookings.Payment", b =>
                {
                    b.HasOne("Ebiograf.Web.API.Models.Bookings.Booking", "Booking")
                        .WithOne("Payment")
                        .HasForeignKey("Ebiograf.Web.API.Models.Bookings.Payment", "BookingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Cinema.Cinema", b =>
                {
                    b.HasOne("Ebiograf.Web.API.Models.Cinema.CinemaAddress", "CinemaAddresses")
                        .WithOne("Cinema")
                        .HasForeignKey("Ebiograf.Web.API.Models.Cinema.Cinema", "CinemaAddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CinemaAddresses");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Cinema.CinemaHall", b =>
                {
                    b.HasOne("Ebiograf.Web.API.Models.Cinema.Cinema", "Cinema")
                        .WithMany("CinemaHalls")
                        .HasForeignKey("CinemaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Cinema.CinemaSeat", b =>
                {
                    b.HasOne("Ebiograf.Web.API.Models.Cinema.CinemaHall", "CinemaHall")
                        .WithMany("CinemaSeats")
                        .HasForeignKey("CinemaHallID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CinemaHall");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Movie.GenreMovie", b =>
                {
                    b.HasOne("Ebiograf.Web.API.Models.Movie.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenresGenreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ebiograf.Web.API.Models.Movie.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MoviesMovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Show.Show", b =>
                {
                    b.HasOne("Ebiograf.Web.API.Models.Cinema.CinemaHall", "CinemaHall")
                        .WithOne("Show")
                        .HasForeignKey("Ebiograf.Web.API.Models.Show.Show", "CinemaHallID");

                    b.HasOne("Ebiograf.Web.API.Models.Movie.Movie", "Movie")
                        .WithMany("Shows")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CinemaHall");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Show.ShowSeat", b =>
                {
                    b.HasOne("Ebiograf.Web.API.Models.Bookings.Booking", "Booking")
                        .WithMany("ShowSeats")
                        .HasForeignKey("BookingID");

                    b.HasOne("Ebiograf.Web.API.Models.Cinema.CinemaSeat", "CinemaSeat")
                        .WithMany()
                        .HasForeignKey("CinemaSeatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ebiograf.Web.API.Models.Show.Show", "Show")
                        .WithMany("ShowSeats")
                        .HasForeignKey("ShowID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("CinemaSeat");

                    b.Navigation("Show");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Snacks.Snack", b =>
                {
                    b.HasOne("Ebiograf.Web.API.Models.Bookings.Booking", "Booking")
                        .WithMany("Snacks")
                        .HasForeignKey("BookingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ebiograf.Web.API.Models.Snacks.Product", "Product")
                        .WithMany("Snacks")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EBiograf.Web.Api.Models.User", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Bookings.Booking", b =>
                {
                    b.Navigation("Payment");

                    b.Navigation("ShowSeats");

                    b.Navigation("Snacks");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Cinema.Cinema", b =>
                {
                    b.Navigation("CinemaHalls");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Cinema.CinemaAddress", b =>
                {
                    b.Navigation("Cinema");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Cinema.CinemaHall", b =>
                {
                    b.Navigation("CinemaSeats");

                    b.Navigation("Show");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Movie.Movie", b =>
                {
                    b.Navigation("Shows");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Show.Show", b =>
                {
                    b.Navigation("Booking");

                    b.Navigation("ShowSeats");
                });

            modelBuilder.Entity("Ebiograf.Web.API.Models.Snacks.Product", b =>
                {
                    b.Navigation("Snacks");
                });
#pragma warning restore 612, 618
        }
    }
}
