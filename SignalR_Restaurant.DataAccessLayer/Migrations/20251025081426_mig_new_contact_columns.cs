using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR_Restaurant.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_new_contact_columns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FooterTitle",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpenDaysNote",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpeningDays",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpeningHours",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FooterTitle",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "OpenDaysNote",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "OpeningDays",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "OpeningHours",
                table: "Contacts");
        }
    }
}
