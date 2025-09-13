using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR_Restaurant.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_remove_StatusType_enum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Categories SET Status = 1 WHERE Status = 'Active'");
            migrationBuilder.Sql("UPDATE Categories SET Status = 0 WHERE Status = 'Passive'");
            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Testimonials",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Products",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Categories",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Categories SET Status = 'Active' WHERE Status = 1");
            migrationBuilder.Sql("UPDATE Categories SET Status = 'Passive' WHERE Status = 0");
            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Testimonials",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");
        }
    }
}
