using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FInProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedMainModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssetTables",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NonCurrentAssetId = table.Column<Guid>(type: "uuid", nullable: false),
                    CurrentAssetId = table.Column<Guid>(type: "uuid", nullable: false),
                    NonCurrentAssetsHeldForSaleDisposalGroupId = table.Column<Guid>(type: "uuid", nullable: false),
                    RegisteredCapitalId = table.Column<Guid>(type: "uuid", nullable: false),
                    LongTermLiabilitiesAndProvisionId = table.Column<Guid>(type: "uuid", nullable: false),
                    CurrentLiabilitiesAndProvisionId = table.Column<Guid>(type: "uuid", nullable: false),
                    LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroupId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetTables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssetTables_CurrentAssets_CurrentAssetId",
                        column: x => x.CurrentAssetId,
                        principalTable: "CurrentAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetTables_CurrentLiabilitiesAndProvisions_CurrentLiabilit~",
                        column: x => x.CurrentLiabilitiesAndProvisionId,
                        principalTable: "CurrentLiabilitiesAndProvisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetTables_LiabilitiesRelatedToNonCurrentAssetsHeldForSale~",
                        column: x => x.LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroupId,
                        principalTable: "LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetTables_LongTermLiabilitiesAndProvisions_LongTermLiabil~",
                        column: x => x.LongTermLiabilitiesAndProvisionId,
                        principalTable: "LongTermLiabilitiesAndProvisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetTables_NonCurrentAssetsHeldForSaleDisposalGroups_NonCu~",
                        column: x => x.NonCurrentAssetsHeldForSaleDisposalGroupId,
                        principalTable: "NonCurrentAssetsHeldForSaleDisposalGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetTables_NonCurrentAssets_NonCurrentAssetId",
                        column: x => x.NonCurrentAssetId,
                        principalTable: "NonCurrentAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetTables_RegisteredCapitals_RegisteredCapitalId",
                        column: x => x.RegisteredCapitalId,
                        principalTable: "RegisteredCapitals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssetTables_CurrentAssetId",
                table: "AssetTables",
                column: "CurrentAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetTables_CurrentLiabilitiesAndProvisionId",
                table: "AssetTables",
                column: "CurrentLiabilitiesAndProvisionId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetTables_LiabilitiesRelatedToNonCurrentAssetsHeldForSale~",
                table: "AssetTables",
                column: "LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetTables_LongTermLiabilitiesAndProvisionId",
                table: "AssetTables",
                column: "LongTermLiabilitiesAndProvisionId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetTables_NonCurrentAssetId",
                table: "AssetTables",
                column: "NonCurrentAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetTables_NonCurrentAssetsHeldForSaleDisposalGroupId",
                table: "AssetTables",
                column: "NonCurrentAssetsHeldForSaleDisposalGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetTables_RegisteredCapitalId",
                table: "AssetTables",
                column: "RegisteredCapitalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetTables");
        }
    }
}
