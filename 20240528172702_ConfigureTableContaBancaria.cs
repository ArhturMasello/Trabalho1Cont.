using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class ConfigureTableContaBancaria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroConta",
                table: "ContasBancarias");

            migrationBuilder.DropColumn(
                name: "SaldoConta",
                table: "ContasBancarias");

            migrationBuilder.RenameColumn(
                name: "NomeCliente",
                table: "ContasBancarias",
                newName: "nomeCliente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nomeCliente",
                table: "ContasBancarias",
                newName: "NomeCliente");

            migrationBuilder.AddColumn<int>(
                name: "NumeroConta",
                table: "ContasBancarias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "SaldoConta",
                table: "ContasBancarias",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
