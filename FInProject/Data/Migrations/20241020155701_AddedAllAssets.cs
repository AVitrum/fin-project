using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FInProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedAllAssets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CurrentLiabilitiesAndProvisions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ShortTermBankLoansId = table.Column<Guid>(type: "uuid", nullable: false),
                    CurrentAccountsPayableLongTermLiabilitiesId = table.Column<Guid>(type: "uuid", nullable: false),
                    CurrentAccountsPayableGoodsAndServicesId = table.Column<Guid>(type: "uuid", nullable: false),
                    CurrentAccountsPayableBudgetSettlementsId = table.Column<Guid>(type: "uuid", nullable: false),
                    CurrentAccountsPayableIncludingIncomeTaxId = table.Column<Guid>(type: "uuid", nullable: false),
                    CurrentAccountsPayableInsuranceSettlementsId = table.Column<Guid>(type: "uuid", nullable: false),
                    CurrentAccountsPayableWageSettlementsId = table.Column<Guid>(type: "uuid", nullable: false),
                    CurrentProvisionsId = table.Column<Guid>(type: "uuid", nullable: false),
                    DeferredIncomeId = table.Column<Guid>(type: "uuid", nullable: false),
                    OtherCurrentLiabilitiesId = table.Column<Guid>(type: "uuid", nullable: false),
                    SumId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentLiabilitiesAndProvisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrentLiabilitiesAndProvisions_Assets_CurrentAccountsPayab~",
                        column: x => x.CurrentAccountsPayableBudgetSettlementsId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentLiabilitiesAndProvisions_Assets_CurrentAccountsPaya~1",
                        column: x => x.CurrentAccountsPayableGoodsAndServicesId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentLiabilitiesAndProvisions_Assets_CurrentAccountsPaya~2",
                        column: x => x.CurrentAccountsPayableIncludingIncomeTaxId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentLiabilitiesAndProvisions_Assets_CurrentAccountsPaya~3",
                        column: x => x.CurrentAccountsPayableInsuranceSettlementsId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentLiabilitiesAndProvisions_Assets_CurrentAccountsPaya~4",
                        column: x => x.CurrentAccountsPayableLongTermLiabilitiesId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentLiabilitiesAndProvisions_Assets_CurrentAccountsPaya~5",
                        column: x => x.CurrentAccountsPayableWageSettlementsId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentLiabilitiesAndProvisions_Assets_CurrentProvisionsId",
                        column: x => x.CurrentProvisionsId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentLiabilitiesAndProvisions_Assets_DeferredIncomeId",
                        column: x => x.DeferredIncomeId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentLiabilitiesAndProvisions_Assets_OtherCurrentLiabilit~",
                        column: x => x.OtherCurrentLiabilitiesId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentLiabilitiesAndProvisions_Assets_ShortTermBankLoansId",
                        column: x => x.ShortTermBankLoansId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentLiabilitiesAndProvisions_Assets_SumId",
                        column: x => x.SumId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LiabilitiesRelatedToNonCurrentAssetsHeldForSaleId = table.Column<Guid>(type: "uuid", nullable: false),
                    BalanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGrou~", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGrou~",
                        column: x => x.BalanceId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGro~1",
                        column: x => x.LiabilitiesRelatedToNonCurrentAssetsHeldForSaleId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LongTermLiabilitiesAndProvisions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DeferredTaxLiabilitiesId = table.Column<Guid>(type: "uuid", nullable: false),
                    LongTermBankLoansId = table.Column<Guid>(type: "uuid", nullable: false),
                    OtherLongTermLiabilitiesId = table.Column<Guid>(type: "uuid", nullable: false),
                    LongTermProvisionsId = table.Column<Guid>(type: "uuid", nullable: false),
                    TargetFinancingId = table.Column<Guid>(type: "uuid", nullable: false),
                    SumId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LongTermLiabilitiesAndProvisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LongTermLiabilitiesAndProvisions_Assets_DeferredTaxLiabilit~",
                        column: x => x.DeferredTaxLiabilitiesId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LongTermLiabilitiesAndProvisions_Assets_LongTermBankLoansId",
                        column: x => x.LongTermBankLoansId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LongTermLiabilitiesAndProvisions_Assets_LongTermProvisionsId",
                        column: x => x.LongTermProvisionsId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LongTermLiabilitiesAndProvisions_Assets_OtherLongTermLiabil~",
                        column: x => x.OtherLongTermLiabilitiesId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LongTermLiabilitiesAndProvisions_Assets_SumId",
                        column: x => x.SumId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LongTermLiabilitiesAndProvisions_Assets_TargetFinancingId",
                        column: x => x.TargetFinancingId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NonCurrentAssets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IntangibleAssetsId = table.Column<Guid>(type: "uuid", nullable: false),
                    OriginalCostId = table.Column<Guid>(type: "uuid", nullable: false),
                    AccumulatedDepreciationId = table.Column<Guid>(type: "uuid", nullable: false),
                    UncompletedCapitalInvestmentsId = table.Column<Guid>(type: "uuid", nullable: false),
                    FixedAssetsId = table.Column<Guid>(type: "uuid", nullable: false),
                    OriginalCostOfFixedAssetsId = table.Column<Guid>(type: "uuid", nullable: false),
                    WearId = table.Column<Guid>(type: "uuid", nullable: false),
                    InvestmentPropertyId = table.Column<Guid>(type: "uuid", nullable: false),
                    LongTermBiologicalAssetsId = table.Column<Guid>(type: "uuid", nullable: false),
                    LongTermFinancialInvestmentsId = table.Column<Guid>(type: "uuid", nullable: false),
                    OtherFinancialInvestmentsId = table.Column<Guid>(type: "uuid", nullable: false),
                    LongTermReceivablesId = table.Column<Guid>(type: "uuid", nullable: false),
                    DeferredTaxAssetsId = table.Column<Guid>(type: "uuid", nullable: false),
                    OtherNonCurrentAssetsId = table.Column<Guid>(type: "uuid", nullable: false),
                    SumId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonCurrentAssets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NonCurrentAssets_Assets_AccumulatedDepreciationId",
                        column: x => x.AccumulatedDepreciationId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NonCurrentAssets_Assets_DeferredTaxAssetsId",
                        column: x => x.DeferredTaxAssetsId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NonCurrentAssets_Assets_FixedAssetsId",
                        column: x => x.FixedAssetsId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NonCurrentAssets_Assets_IntangibleAssetsId",
                        column: x => x.IntangibleAssetsId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NonCurrentAssets_Assets_InvestmentPropertyId",
                        column: x => x.InvestmentPropertyId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NonCurrentAssets_Assets_LongTermBiologicalAssetsId",
                        column: x => x.LongTermBiologicalAssetsId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NonCurrentAssets_Assets_LongTermFinancialInvestmentsId",
                        column: x => x.LongTermFinancialInvestmentsId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NonCurrentAssets_Assets_LongTermReceivablesId",
                        column: x => x.LongTermReceivablesId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NonCurrentAssets_Assets_OriginalCostId",
                        column: x => x.OriginalCostId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NonCurrentAssets_Assets_OriginalCostOfFixedAssetsId",
                        column: x => x.OriginalCostOfFixedAssetsId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NonCurrentAssets_Assets_OtherFinancialInvestmentsId",
                        column: x => x.OtherFinancialInvestmentsId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NonCurrentAssets_Assets_OtherNonCurrentAssetsId",
                        column: x => x.OtherNonCurrentAssetsId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NonCurrentAssets_Assets_SumId",
                        column: x => x.SumId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NonCurrentAssets_Assets_UncompletedCapitalInvestmentsId",
                        column: x => x.UncompletedCapitalInvestmentsId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NonCurrentAssets_Assets_WearId",
                        column: x => x.WearId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NonCurrentAssetsHeldForSaleDisposalGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NonCurrentAssetsHeldForSaleId = table.Column<Guid>(type: "uuid", nullable: false),
                    BalanceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonCurrentAssetsHeldForSaleDisposalGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NonCurrentAssetsHeldForSaleDisposalGroups_Assets_BalanceId",
                        column: x => x.BalanceId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NonCurrentAssetsHeldForSaleDisposalGroups_Assets_NonCurrent~",
                        column: x => x.NonCurrentAssetsHeldForSaleId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegisteredCapitals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PaidInCapitalId = table.Column<Guid>(type: "uuid", nullable: false),
                    RevaluationReserveId = table.Column<Guid>(type: "uuid", nullable: false),
                    AdditionalCapitalId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReserveCapitalId = table.Column<Guid>(type: "uuid", nullable: false),
                    RetainedEarningsId = table.Column<Guid>(type: "uuid", nullable: false),
                    UnpaidCapitalId = table.Column<Guid>(type: "uuid", nullable: false),
                    WithdrawnCapitalId = table.Column<Guid>(type: "uuid", nullable: false),
                    SumId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisteredCapitals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegisteredCapitals_Assets_AdditionalCapitalId",
                        column: x => x.AdditionalCapitalId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisteredCapitals_Assets_PaidInCapitalId",
                        column: x => x.PaidInCapitalId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisteredCapitals_Assets_ReserveCapitalId",
                        column: x => x.ReserveCapitalId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisteredCapitals_Assets_RetainedEarningsId",
                        column: x => x.RetainedEarningsId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisteredCapitals_Assets_RevaluationReserveId",
                        column: x => x.RevaluationReserveId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisteredCapitals_Assets_SumId",
                        column: x => x.SumId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisteredCapitals_Assets_UnpaidCapitalId",
                        column: x => x.UnpaidCapitalId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisteredCapitals_Assets_WithdrawnCapitalId",
                        column: x => x.WithdrawnCapitalId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CurrentLiabilitiesAndProvisions_CurrentAccountsPayableBudge~",
                table: "CurrentLiabilitiesAndProvisions",
                column: "CurrentAccountsPayableBudgetSettlementsId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentLiabilitiesAndProvisions_CurrentAccountsPayableGoods~",
                table: "CurrentLiabilitiesAndProvisions",
                column: "CurrentAccountsPayableGoodsAndServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentLiabilitiesAndProvisions_CurrentAccountsPayableInclu~",
                table: "CurrentLiabilitiesAndProvisions",
                column: "CurrentAccountsPayableIncludingIncomeTaxId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentLiabilitiesAndProvisions_CurrentAccountsPayableInsur~",
                table: "CurrentLiabilitiesAndProvisions",
                column: "CurrentAccountsPayableInsuranceSettlementsId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentLiabilitiesAndProvisions_CurrentAccountsPayableLongT~",
                table: "CurrentLiabilitiesAndProvisions",
                column: "CurrentAccountsPayableLongTermLiabilitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentLiabilitiesAndProvisions_CurrentAccountsPayableWageS~",
                table: "CurrentLiabilitiesAndProvisions",
                column: "CurrentAccountsPayableWageSettlementsId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentLiabilitiesAndProvisions_CurrentProvisionsId",
                table: "CurrentLiabilitiesAndProvisions",
                column: "CurrentProvisionsId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentLiabilitiesAndProvisions_DeferredIncomeId",
                table: "CurrentLiabilitiesAndProvisions",
                column: "DeferredIncomeId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentLiabilitiesAndProvisions_OtherCurrentLiabilitiesId",
                table: "CurrentLiabilitiesAndProvisions",
                column: "OtherCurrentLiabilitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentLiabilitiesAndProvisions_ShortTermBankLoansId",
                table: "CurrentLiabilitiesAndProvisions",
                column: "ShortTermBankLoansId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentLiabilitiesAndProvisions_SumId",
                table: "CurrentLiabilitiesAndProvisions",
                column: "SumId");

            migrationBuilder.CreateIndex(
                name: "IX_LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGro~1",
                table: "LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroups",
                column: "LiabilitiesRelatedToNonCurrentAssetsHeldForSaleId");

            migrationBuilder.CreateIndex(
                name: "IX_LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGrou~",
                table: "LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroups",
                column: "BalanceId");

            migrationBuilder.CreateIndex(
                name: "IX_LongTermLiabilitiesAndProvisions_DeferredTaxLiabilitiesId",
                table: "LongTermLiabilitiesAndProvisions",
                column: "DeferredTaxLiabilitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_LongTermLiabilitiesAndProvisions_LongTermBankLoansId",
                table: "LongTermLiabilitiesAndProvisions",
                column: "LongTermBankLoansId");

            migrationBuilder.CreateIndex(
                name: "IX_LongTermLiabilitiesAndProvisions_LongTermProvisionsId",
                table: "LongTermLiabilitiesAndProvisions",
                column: "LongTermProvisionsId");

            migrationBuilder.CreateIndex(
                name: "IX_LongTermLiabilitiesAndProvisions_OtherLongTermLiabilitiesId",
                table: "LongTermLiabilitiesAndProvisions",
                column: "OtherLongTermLiabilitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_LongTermLiabilitiesAndProvisions_SumId",
                table: "LongTermLiabilitiesAndProvisions",
                column: "SumId");

            migrationBuilder.CreateIndex(
                name: "IX_LongTermLiabilitiesAndProvisions_TargetFinancingId",
                table: "LongTermLiabilitiesAndProvisions",
                column: "TargetFinancingId");

            migrationBuilder.CreateIndex(
                name: "IX_NonCurrentAssets_AccumulatedDepreciationId",
                table: "NonCurrentAssets",
                column: "AccumulatedDepreciationId");

            migrationBuilder.CreateIndex(
                name: "IX_NonCurrentAssets_DeferredTaxAssetsId",
                table: "NonCurrentAssets",
                column: "DeferredTaxAssetsId");

            migrationBuilder.CreateIndex(
                name: "IX_NonCurrentAssets_FixedAssetsId",
                table: "NonCurrentAssets",
                column: "FixedAssetsId");

            migrationBuilder.CreateIndex(
                name: "IX_NonCurrentAssets_IntangibleAssetsId",
                table: "NonCurrentAssets",
                column: "IntangibleAssetsId");

            migrationBuilder.CreateIndex(
                name: "IX_NonCurrentAssets_InvestmentPropertyId",
                table: "NonCurrentAssets",
                column: "InvestmentPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_NonCurrentAssets_LongTermBiologicalAssetsId",
                table: "NonCurrentAssets",
                column: "LongTermBiologicalAssetsId");

            migrationBuilder.CreateIndex(
                name: "IX_NonCurrentAssets_LongTermFinancialInvestmentsId",
                table: "NonCurrentAssets",
                column: "LongTermFinancialInvestmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_NonCurrentAssets_LongTermReceivablesId",
                table: "NonCurrentAssets",
                column: "LongTermReceivablesId");

            migrationBuilder.CreateIndex(
                name: "IX_NonCurrentAssets_OriginalCostId",
                table: "NonCurrentAssets",
                column: "OriginalCostId");

            migrationBuilder.CreateIndex(
                name: "IX_NonCurrentAssets_OriginalCostOfFixedAssetsId",
                table: "NonCurrentAssets",
                column: "OriginalCostOfFixedAssetsId");

            migrationBuilder.CreateIndex(
                name: "IX_NonCurrentAssets_OtherFinancialInvestmentsId",
                table: "NonCurrentAssets",
                column: "OtherFinancialInvestmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_NonCurrentAssets_OtherNonCurrentAssetsId",
                table: "NonCurrentAssets",
                column: "OtherNonCurrentAssetsId");

            migrationBuilder.CreateIndex(
                name: "IX_NonCurrentAssets_SumId",
                table: "NonCurrentAssets",
                column: "SumId");

            migrationBuilder.CreateIndex(
                name: "IX_NonCurrentAssets_UncompletedCapitalInvestmentsId",
                table: "NonCurrentAssets",
                column: "UncompletedCapitalInvestmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_NonCurrentAssets_WearId",
                table: "NonCurrentAssets",
                column: "WearId");

            migrationBuilder.CreateIndex(
                name: "IX_NonCurrentAssetsHeldForSaleDisposalGroups_BalanceId",
                table: "NonCurrentAssetsHeldForSaleDisposalGroups",
                column: "BalanceId");

            migrationBuilder.CreateIndex(
                name: "IX_NonCurrentAssetsHeldForSaleDisposalGroups_NonCurrentAssetsH~",
                table: "NonCurrentAssetsHeldForSaleDisposalGroups",
                column: "NonCurrentAssetsHeldForSaleId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredCapitals_AdditionalCapitalId",
                table: "RegisteredCapitals",
                column: "AdditionalCapitalId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredCapitals_PaidInCapitalId",
                table: "RegisteredCapitals",
                column: "PaidInCapitalId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredCapitals_ReserveCapitalId",
                table: "RegisteredCapitals",
                column: "ReserveCapitalId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredCapitals_RetainedEarningsId",
                table: "RegisteredCapitals",
                column: "RetainedEarningsId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredCapitals_RevaluationReserveId",
                table: "RegisteredCapitals",
                column: "RevaluationReserveId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredCapitals_SumId",
                table: "RegisteredCapitals",
                column: "SumId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredCapitals_UnpaidCapitalId",
                table: "RegisteredCapitals",
                column: "UnpaidCapitalId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredCapitals_WithdrawnCapitalId",
                table: "RegisteredCapitals",
                column: "WithdrawnCapitalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentLiabilitiesAndProvisions");

            migrationBuilder.DropTable(
                name: "LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroups");

            migrationBuilder.DropTable(
                name: "LongTermLiabilitiesAndProvisions");

            migrationBuilder.DropTable(
                name: "NonCurrentAssets");

            migrationBuilder.DropTable(
                name: "NonCurrentAssetsHeldForSaleDisposalGroups");

            migrationBuilder.DropTable(
                name: "RegisteredCapitals");
        }
    }
}
