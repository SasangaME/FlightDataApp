using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightData.Db.Migrations
{
    /// <inheritdoc />
    public partial class Location_City : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Locations",
                newName: "City");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "City",
                table: "Locations",
                newName: "Name");
        }
    }
}
