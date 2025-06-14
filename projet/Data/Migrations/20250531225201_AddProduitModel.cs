using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projet.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProduitModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Produit",
                table: "Produit");

            migrationBuilder.RenameTable(
                name: "Produit",
                newName: "Produits");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produits",
                table: "Produits",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Produits",
                table: "Produits");

            migrationBuilder.RenameTable(
                name: "Produits",
                newName: "Produit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produit",
                table: "Produit",
                column: "Id");
        }
    }
}
