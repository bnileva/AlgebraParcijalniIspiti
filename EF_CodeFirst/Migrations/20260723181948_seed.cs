using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "Employees",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "EmpolyeeId",
                table: "Employees",
                newName: "EmployeeId");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "CompanyName", "Designation", "Name" },
                values: new object[] { 1, "Ilica 25, Zagreb", "Komunalac d.o.o.", "Profesionalni upravljač kamionom", "Stipan Ljudevit Drmić" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Employees",
                newName: "Adress");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Employees",
                newName: "EmpolyeeId");
        }
    }
}
