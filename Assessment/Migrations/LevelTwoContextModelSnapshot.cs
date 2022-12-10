﻿// <auto-generated />
using System;
using Assessment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assessment.Migrations
{
    [DbContext(typeof(LevelTwoContext))]
    partial class LevelTwoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Assessment.Models.CalendarEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ListingId")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Calendar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Available = true,
                            Date = new DateTime(2016, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 1,
                            Price = 85f
                        },
                        new
                        {
                            Id = 2,
                            Available = true,
                            Date = new DateTime(2016, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 1,
                            Price = 65f
                        },
                        new
                        {
                            Id = 3,
                            Available = true,
                            Date = new DateTime(2016, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 1,
                            Price = 75f
                        },
                        new
                        {
                            Id = 4,
                            Available = true,
                            Date = new DateTime(2016, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 1,
                            Price = 85f
                        },
                        new
                        {
                            Id = 5,
                            Available = true,
                            Date = new DateTime(2016, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 1,
                            Price = 85f
                        },
                        new
                        {
                            Id = 6,
                            Available = true,
                            Date = new DateTime(2016, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 1,
                            Price = 85f
                        },
                        new
                        {
                            Id = 7,
                            Available = true,
                            Date = new DateTime(2016, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 1,
                            Price = 85f
                        },
                        new
                        {
                            Id = 8,
                            Available = true,
                            Date = new DateTime(2016, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 1,
                            Price = 85f
                        },
                        new
                        {
                            Id = 9,
                            Available = false,
                            Date = new DateTime(2016, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 1,
                            Price = 85f
                        },
                        new
                        {
                            Id = 10,
                            Available = false,
                            Date = new DateTime(2016, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 1,
                            Price = 85f
                        },
                        new
                        {
                            Id = 11,
                            Available = false,
                            Date = new DateTime(2016, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 1,
                            Price = 85f
                        },
                        new
                        {
                            Id = 12,
                            Available = true,
                            Date = new DateTime(2016, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 2,
                            Price = 85f
                        },
                        new
                        {
                            Id = 13,
                            Available = true,
                            Date = new DateTime(2016, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 2,
                            Price = 65f
                        },
                        new
                        {
                            Id = 14,
                            Available = true,
                            Date = new DateTime(2016, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 2,
                            Price = 75f
                        },
                        new
                        {
                            Id = 15,
                            Available = true,
                            Date = new DateTime(2016, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 2,
                            Price = 85f
                        },
                        new
                        {
                            Id = 16,
                            Available = true,
                            Date = new DateTime(2016, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 2,
                            Price = 85f
                        },
                        new
                        {
                            Id = 17,
                            Available = true,
                            Date = new DateTime(2016, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 2,
                            Price = 85f
                        },
                        new
                        {
                            Id = 18,
                            Available = true,
                            Date = new DateTime(2016, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 2,
                            Price = 85f
                        },
                        new
                        {
                            Id = 19,
                            Available = true,
                            Date = new DateTime(2016, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 2,
                            Price = 85f
                        },
                        new
                        {
                            Id = 20,
                            Available = false,
                            Date = new DateTime(2016, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 2,
                            Price = 85f
                        },
                        new
                        {
                            Id = 21,
                            Available = false,
                            Date = new DateTime(2016, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 2,
                            Price = 85f
                        },
                        new
                        {
                            Id = 22,
                            Available = false,
                            Date = new DateTime(2016, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 2,
                            Price = 85f
                        });
                });

            modelBuilder.Entity("Assessment.Models.Listing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ListingUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Listings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Enjoy Queen Anne Living",
                            ListingUrl = "https://www.airbnb.com/rooms/241032,20160104002432,2016-01-04,Stylish Queen Anne Apartment",
                            Name = "Queen Anne Apartment",
                            PropertyType = "apartment"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Enjoy craftmanship",
                            ListingUrl = "https://www.airbnb.com/rooms/278830,20160104002432,2016-01-04,Charming craftsman 3 bdm house",
                            Name = "Charming craftsman",
                            PropertyType = "apartment"
                        },
                        new
                        {
                            Id = 3,
                            Description = "RVezy is awesome!",
                            ListingUrl = "https://www.airbnb.com/rooms/1909058,20160104002432,2016-01-04,Queen Anne Private Bed and Bath",
                            Name = "Queen Anne Private",
                            PropertyType = "house"
                        });
                });

            modelBuilder.Entity("Assessment.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ListingId")
                        .HasColumnType("int");

                    b.Property<int>("ReviewerId")
                        .HasColumnType("int");

                    b.Property<string>("ReviewerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 38917982,
                            Comments = "Cute and cozy place.",
                            Date = new DateTime(2015, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 1,
                            ReviewerId = 28943674,
                            ReviewerName = "Bianca"
                        },
                        new
                        {
                            Id = 38917981,
                            Comments = "Perfect location to everything!",
                            Date = new DateTime(2015, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListingId = 2,
                            ReviewerId = 28943675,
                            ReviewerName = "Blanca"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
