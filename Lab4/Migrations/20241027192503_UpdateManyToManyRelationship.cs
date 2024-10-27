using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab4.Migrations
{
    /// <inheritdoc />
    public partial class UpdateManyToManyRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsSuppliers_Product_ProductsID",
                table: "ProductsSuppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsSuppliers_Suppliers_SuppliersID",
                table: "ProductsSuppliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsSuppliers",
                table: "ProductsSuppliers");

            migrationBuilder.RenameTable(
                name: "ProductsSuppliers",
                newName: "ProductSuppliers");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsSuppliers_SuppliersID",
                table: "ProductSuppliers",
                newName: "IX_ProductSuppliers_SuppliersID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSuppliers",
                table: "ProductSuppliers",
                columns: new[] { "ProductsID", "SuppliersID" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSuppliers_Product_ProductsID",
                table: "ProductSuppliers",
                column: "ProductsID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSuppliers_Suppliers_SuppliersID",
                table: "ProductSuppliers",
                column: "SuppliersID",
                principalTable: "Suppliers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSuppliers_Product_ProductsID",
                table: "ProductSuppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSuppliers_Suppliers_SuppliersID",
                table: "ProductSuppliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSuppliers",
                table: "ProductSuppliers");

            migrationBuilder.RenameTable(
                name: "ProductSuppliers",
                newName: "ProductsSuppliers");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSuppliers_SuppliersID",
                table: "ProductsSuppliers",
                newName: "IX_ProductsSuppliers_SuppliersID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsSuppliers",
                table: "ProductsSuppliers",
                columns: new[] { "ProductsID", "SuppliersID" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsSuppliers_Product_ProductsID",
                table: "ProductsSuppliers",
                column: "ProductsID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsSuppliers_Suppliers_SuppliersID",
                table: "ProductsSuppliers",
                column: "SuppliersID",
                principalTable: "Suppliers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
