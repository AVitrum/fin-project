using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FInProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedCurrentAssetForTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<int>(type: "integer", nullable: false),
                    OriginalName = table.Column<string>(type: "text", nullable: false),
                    AtStart = table.Column<decimal>(type: "numeric", nullable: false),
                    AtEnd = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurrentAssets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    InventoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    CurrentBiologicalAssetsId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReceivablesForGoodsAndServicesId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReceivablesForSettlementsAdvancesIssuedId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReceivablesForSettlementsBudgetId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReceivablesForSettlementsIncludingIncomeTaxId = table.Column<Guid>(type: "uuid", nullable: false),
                    OtherCurrentReceivablesId = table.Column<Guid>(type: "uuid", nullable: false),
                    CurrentFinancialInvestmentsId = table.Column<Guid>(type: "uuid", nullable: false),
                    CashAndCashEquivalentsId = table.Column<Guid>(type: "uuid", nullable: false),
                    PrepaidExpensesId = table.Column<Guid>(type: "uuid", nullable: false),
                    OtherCurrentAssetsId = table.Column<Guid>(type: "uuid", nullable: false),
                    SumId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentAssets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrentAssets_Assets_CashAndCashEquivalentsId",
                        column: x => x.CashAndCashEquivalentsId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentAssets_Assets_CurrentBiologicalAssetsId",
                        column: x => x.CurrentBiologicalAssetsId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentAssets_Assets_CurrentFinancialInvestmentsId",
                        column: x => x.CurrentFinancialInvestmentsId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentAssets_Assets_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentAssets_Assets_OtherCurrentAssetsId",
                        column: x => x.OtherCurrentAssetsId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentAssets_Assets_OtherCurrentReceivablesId",
                        column: x => x.OtherCurrentReceivablesId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentAssets_Assets_PrepaidExpensesId",
                        column: x => x.PrepaidExpensesId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentAssets_Assets_ReceivablesForGoodsAndServicesId",
                        column: x => x.ReceivablesForGoodsAndServicesId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentAssets_Assets_ReceivablesForSettlementsAdvancesIssue~",
                        column: x => x.ReceivablesForSettlementsAdvancesIssuedId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentAssets_Assets_ReceivablesForSettlementsBudgetId",
                        column: x => x.ReceivablesForSettlementsBudgetId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentAssets_Assets_ReceivablesForSettlementsIncludingInco~",
                        column: x => x.ReceivablesForSettlementsIncludingIncomeTaxId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentAssets_Assets_SumId",
                        column: x => x.SumId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CurrentAssets_CashAndCashEquivalentsId",
                table: "CurrentAssets",
                column: "CashAndCashEquivalentsId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentAssets_CurrentBiologicalAssetsId",
                table: "CurrentAssets",
                column: "CurrentBiologicalAssetsId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentAssets_CurrentFinancialInvestmentsId",
                table: "CurrentAssets",
                column: "CurrentFinancialInvestmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentAssets_InventoryId",
                table: "CurrentAssets",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentAssets_OtherCurrentAssetsId",
                table: "CurrentAssets",
                column: "OtherCurrentAssetsId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentAssets_OtherCurrentReceivablesId",
                table: "CurrentAssets",
                column: "OtherCurrentReceivablesId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentAssets_PrepaidExpensesId",
                table: "CurrentAssets",
                column: "PrepaidExpensesId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentAssets_ReceivablesForGoodsAndServicesId",
                table: "CurrentAssets",
                column: "ReceivablesForGoodsAndServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentAssets_ReceivablesForSettlementsAdvancesIssuedId",
                table: "CurrentAssets",
                column: "ReceivablesForSettlementsAdvancesIssuedId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentAssets_ReceivablesForSettlementsBudgetId",
                table: "CurrentAssets",
                column: "ReceivablesForSettlementsBudgetId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentAssets_ReceivablesForSettlementsIncludingIncomeTaxId",
                table: "CurrentAssets",
                column: "ReceivablesForSettlementsIncludingIncomeTaxId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentAssets_SumId",
                table: "CurrentAssets",
                column: "SumId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentAssets");

            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(256)",
                oldMaxLength: 256);
        }
    }
}
