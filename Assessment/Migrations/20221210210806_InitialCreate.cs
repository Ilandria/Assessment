using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assessment.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calendar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListingId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Listings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListingUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListingId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReviewerId = table.Column<int>(type: "int", nullable: false),
                    ReviewerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Calendar",
                columns: new[] { "Id", "Available", "Date", "ListingId", "Price" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2016, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 85f },
                    { 2, true, new DateTime(2016, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 65f },
                    { 3, true, new DateTime(2016, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 75f },
                    { 4, true, new DateTime(2016, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 85f },
                    { 5, true, new DateTime(2016, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 85f },
                    { 6, true, new DateTime(2016, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 85f },
                    { 7, true, new DateTime(2016, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 85f },
                    { 8, true, new DateTime(2016, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 85f },
                    { 9, false, new DateTime(2016, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 85f },
                    { 10, false, new DateTime(2016, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 85f },
                    { 11, false, new DateTime(2016, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 85f },
                    { 12, true, new DateTime(2016, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 85f },
                    { 13, true, new DateTime(2016, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 65f },
                    { 14, true, new DateTime(2016, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 75f },
                    { 15, true, new DateTime(2016, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 85f },
                    { 16, true, new DateTime(2016, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 85f },
                    { 17, true, new DateTime(2016, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 85f },
                    { 18, true, new DateTime(2016, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 85f },
                    { 19, true, new DateTime(2016, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 85f },
                    { 20, false, new DateTime(2016, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 85f },
                    { 21, false, new DateTime(2016, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 85f },
                    { 22, false, new DateTime(2016, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 85f }
                });

            migrationBuilder.InsertData(
                table: "Listings",
                columns: new[] { "Id", "Description", "ListingUrl", "Name", "PropertyType" },
                values: new object[,]
                {
                    { 1, "Enjoy Queen Anne Living", "https://www.airbnb.com/rooms/241032,20160104002432,2016-01-04,Stylish Queen Anne Apartment", "Queen Anne Apartment", "apartment" },
                    { 2, "Enjoy craftmanship", "https://www.airbnb.com/rooms/278830,20160104002432,2016-01-04,Charming craftsman 3 bdm house", "Charming craftsman", "apartment" },
                    { 3, "RVezy is awesome!", "https://www.airbnb.com/rooms/1909058,20160104002432,2016-01-04,Queen Anne Private Bed and Bath", "Queen Anne Private", "house" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comments", "Date", "ListingId", "ReviewerId", "ReviewerName" },
                values: new object[,]
                {
                    { 38917981, "Perfect location to everything!", new DateTime(2015, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 28943675, "Blanca" },
                    { 38917982, "Cute and cozy place.", new DateTime(2015, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 28943674, "Bianca" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calendar");

            migrationBuilder.DropTable(
                name: "Listings");

            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
