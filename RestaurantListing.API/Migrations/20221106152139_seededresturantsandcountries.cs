using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantListing.API.Migrations
{
    public partial class seededresturantsandcountries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Resturants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Jamaica" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Haiti" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Spain" });

            migrationBuilder.InsertData(
                table: "Resturants",
                columns: new[] { "Id", "Address", "CountryId", "Description", "Name", "Rating" },
                values: new object[] { 1, "Kingston", 1, "Provide high quality sea food", "FishPot Stop Resturant ", "5 Star" });

            migrationBuilder.InsertData(
                table: "Resturants",
                columns: new[] { "Id", "Address", "CountryId", "Description", "Name", "Rating" },
                values: new object[] { 2, "Port au Prince", 2, "Provide high quality sausy food", "HotSause Resturant ", "5 Star" });

            migrationBuilder.InsertData(
                table: "Resturants",
                columns: new[] { "Id", "Address", "CountryId", "Description", "Name", "Rating" },
                values: new object[] { 3, "Madrid", 3, "Provide high quality Spanish food", "BullThrust Resturant ", "5 Star" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Resturants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resturants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Resturants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Resturants");
        }
    }
}
