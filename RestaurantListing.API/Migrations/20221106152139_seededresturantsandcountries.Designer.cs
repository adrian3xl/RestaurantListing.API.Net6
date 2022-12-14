// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantListing.API.Data;

#nullable disable

namespace RestaurantListing.API.Migrations
{
    [DbContext(typeof(ResturantListingDBContext))]
    [Migration("20221106152139_seededresturantsandcountries")]
    partial class seededresturantsandcountries
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RestaurantListing.API.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Jamaica"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Haiti"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Spain"
                        });
                });

            modelBuilder.Entity("RestaurantListing.API.Data.Resturant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Resturants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Kingston",
                            CountryId = 1,
                            Description = "Provide high quality sea food",
                            Name = "FishPot Stop Resturant ",
                            Rating = "5 Star"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Port au Prince",
                            CountryId = 2,
                            Description = "Provide high quality sausy food",
                            Name = "HotSause Resturant ",
                            Rating = "5 Star"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Madrid",
                            CountryId = 3,
                            Description = "Provide high quality Spanish food",
                            Name = "BullThrust Resturant ",
                            Rating = "5 Star"
                        });
                });

            modelBuilder.Entity("RestaurantListing.API.Data.Resturant", b =>
                {
                    b.HasOne("RestaurantListing.API.Data.Country", "Country")
                        .WithMany("Resturants")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("RestaurantListing.API.Data.Country", b =>
                {
                    b.Navigation("Resturants");
                });
#pragma warning restore 612, 618
        }
    }
}
