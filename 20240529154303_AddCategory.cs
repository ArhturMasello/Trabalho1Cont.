using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AddCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nomeCliente",
                table: "ContasBancarias",
                newName: "NomeCliente");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "ContasBancarias",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "ContasBancarias",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 11);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "ContasBancarias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "SaldoConda",
                table: "ContasBancarias",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContasBancarias_CategoryId",
                table: "ContasBancarias",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContasBancarias_Category_CategoryId",
                table: "ContasBancarias",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContasBancarias_Category_CategoryId",
                table: "ContasBancarias");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_ContasBancarias_CategoryId",
                table: "ContasBancarias");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "ContasBancarias");

            migrationBuilder.DropColumn(
                name: "SaldoConda",
                table: "ContasBancarias");

            migrationBuilder.RenameColumn(
                name: "NomeCliente",
                table: "ContasBancarias",
                newName: "nomeCliente");

            migrationBuilder.AlterColumn<double>(
                name: "Senha",
                table: "ContasBancarias",
                type: "float",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<double>(
                name: "Cpf",
                table: "ContasBancarias",
                type: "float",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);
        }
    }
}
