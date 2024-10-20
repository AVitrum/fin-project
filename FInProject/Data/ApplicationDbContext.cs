using FInProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FInProject.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; init; }
    public DbSet<Asset> Assets { get; set; }
    public DbSet<CurrentAsset> CurrentAssets { get; set; }
    public DbSet<CurrentLiabilitiesAndProvision> CurrentLiabilitiesAndProvisions { get; set; }
    public DbSet<LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroup> LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroups { get; set; }
    public DbSet<LongTermLiabilitiesAndProvision> LongTermLiabilitiesAndProvisions { get; set; }
    public DbSet<NonCurrentAsset> NonCurrentAssets { get; set; }
    public DbSet<NonCurrentAssetsHeldForSaleDisposalGroup> NonCurrentAssetsHeldForSaleDisposalGroups { get; set; }
    public DbSet<RegisteredCapital> RegisteredCapitals { get; set; }
    public DbSet<AssetTable> AssetTables { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CurrentAsset>()
            .HasOne(ca => ca.Inventory)
            .WithMany()
            .HasForeignKey(ca => ca.InventoryId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CurrentAsset>()
            .HasOne(ca => ca.CurrentBiologicalAssets)
            .WithMany()
            .HasForeignKey(ca => ca.CurrentBiologicalAssetsId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CurrentAsset>()
            .HasOne(ca => ca.ReceivablesForGoodsAndServices)
            .WithMany()
            .HasForeignKey(ca => ca.ReceivablesForGoodsAndServicesId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CurrentAsset>()
            .HasOne(ca => ca.ReceivablesForSettlementsAdvancesIssued)
            .WithMany()
            .HasForeignKey(ca => ca.ReceivablesForSettlementsAdvancesIssuedId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CurrentAsset>()
            .HasOne(ca => ca.ReceivablesForSettlementsBudget)
            .WithMany()
            .HasForeignKey(ca => ca.ReceivablesForSettlementsBudgetId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CurrentAsset>()
            .HasOne(ca => ca.ReceivablesForSettlementsIncludingIncomeTax)
            .WithMany()
            .HasForeignKey(ca => ca.ReceivablesForSettlementsIncludingIncomeTaxId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CurrentAsset>()
            .HasOne(ca => ca.OtherCurrentReceivables)
            .WithMany()
            .HasForeignKey(ca => ca.OtherCurrentReceivablesId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CurrentAsset>()
            .HasOne(ca => ca.CurrentFinancialInvestments)
            .WithMany()
            .HasForeignKey(ca => ca.CurrentFinancialInvestmentsId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CurrentAsset>()
            .HasOne(ca => ca.CashAndCashEquivalents)
            .WithMany()
            .HasForeignKey(ca => ca.CashAndCashEquivalentsId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CurrentAsset>()
            .HasOne(ca => ca.PrepaidExpenses)
            .WithMany()
            .HasForeignKey(ca => ca.PrepaidExpensesId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CurrentAsset>()
            .HasOne(ca => ca.OtherCurrentAssets)
            .WithMany()
            .HasForeignKey(ca => ca.OtherCurrentAssetsId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CurrentAsset>()
            .HasOne(ca => ca.Sum)
            .WithMany()
            .HasForeignKey(ca => ca.SumId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CurrentLiabilitiesAndProvision>()
            .HasOne(cl => cl.ShortTermBankLoans)
            .WithMany()
            .HasForeignKey(cl => cl.ShortTermBankLoansId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CurrentLiabilitiesAndProvision>()
            .HasOne(cl => cl.CurrentAccountsPayableLongTermLiabilities)
            .WithMany()
            .HasForeignKey(cl => cl.CurrentAccountsPayableLongTermLiabilitiesId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CurrentLiabilitiesAndProvision>()
            .HasOne(cl => cl.CurrentAccountsPayableGoodsAndServices)
            .WithMany()
            .HasForeignKey(cl => cl.CurrentAccountsPayableGoodsAndServicesId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CurrentLiabilitiesAndProvision>()
            .HasOne(cl => cl.CurrentAccountsPayableBudgetSettlements)
            .WithMany()
            .HasForeignKey(cl => cl.CurrentAccountsPayableBudgetSettlementsId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CurrentLiabilitiesAndProvision>()
            .HasOne(cl => cl.CurrentAccountsPayableIncludingIncomeTax)
            .WithMany()
            .HasForeignKey(cl => cl.CurrentAccountsPayableIncludingIncomeTaxId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CurrentLiabilitiesAndProvision>()
            .HasOne(cl => cl.CurrentAccountsPayableInsuranceSettlements)
            .WithMany()
            .HasForeignKey(cl => cl.CurrentAccountsPayableInsuranceSettlementsId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CurrentLiabilitiesAndProvision>()
            .HasOne(cl => cl.CurrentAccountsPayableWageSettlements)
            .WithMany()
            .HasForeignKey(cl => cl.CurrentAccountsPayableWageSettlementsId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CurrentLiabilitiesAndProvision>()
            .HasOne(cl => cl.CurrentProvisions)
            .WithMany()
            .HasForeignKey(cl => cl.CurrentProvisionsId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CurrentLiabilitiesAndProvision>()
            .HasOne(cl => cl.DeferredIncome)
            .WithMany()
            .HasForeignKey(cl => cl.DeferredIncomeId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CurrentLiabilitiesAndProvision>()
            .HasOne(cl => cl.OtherCurrentLiabilities)
            .WithMany()
            .HasForeignKey(cl => cl.OtherCurrentLiabilitiesId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CurrentLiabilitiesAndProvision>()
            .HasOne(cl => cl.Sum)
            .WithMany()
            .HasForeignKey(cl => cl.SumId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroup>()
            .HasOne(l => l.LiabilitiesRelatedToNonCurrentAssetsHeldForSale)
            .WithMany()
            .HasForeignKey(l => l.LiabilitiesRelatedToNonCurrentAssetsHeldForSaleId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroup>()
            .HasOne(l => l.Balance)
            .WithMany()
            .HasForeignKey(l => l.BalanceId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<LongTermLiabilitiesAndProvision>()
            .HasOne(l => l.DeferredTaxLiabilities)
            .WithMany()
            .HasForeignKey(l => l.DeferredTaxLiabilitiesId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<LongTermLiabilitiesAndProvision>()
            .HasOne(l => l.LongTermBankLoans)
            .WithMany()
            .HasForeignKey(l => l.LongTermBankLoansId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<LongTermLiabilitiesAndProvision>()
            .HasOne(l => l.OtherLongTermLiabilities)
            .WithMany()
            .HasForeignKey(l => l.OtherLongTermLiabilitiesId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<LongTermLiabilitiesAndProvision>()
            .HasOne(l => l.LongTermProvisions)
            .WithMany()
            .HasForeignKey(l => l.LongTermProvisionsId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<LongTermLiabilitiesAndProvision>()
            .HasOne(l => l.TargetFinancing)
            .WithMany()
            .HasForeignKey(l => l.TargetFinancingId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<LongTermLiabilitiesAndProvision>()
            .HasOne(l => l.Sum)
            .WithMany()
            .HasForeignKey(l => l.SumId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<NonCurrentAsset>()
            .HasOne(nc => nc.IntangibleAssets)
            .WithMany()
            .HasForeignKey(nc => nc.IntangibleAssetsId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<NonCurrentAsset>()
            .HasOne(nc => nc.OriginalCost)
            .WithMany()
            .HasForeignKey(nc => nc.OriginalCostId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<NonCurrentAsset>()
            .HasOne(nc => nc.AccumulatedDepreciation)
            .WithMany()
            .HasForeignKey(nc => nc.AccumulatedDepreciationId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<NonCurrentAsset>()
            .HasOne(nc => nc.UncompletedCapitalInvestments)
            .WithMany()
            .HasForeignKey(nc => nc.UncompletedCapitalInvestmentsId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<NonCurrentAsset>()
            .HasOne(nc => nc.FixedAssets)
            .WithMany()
            .HasForeignKey(nc => nc.FixedAssetsId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<NonCurrentAsset>()
            .HasOne(nc => nc.OriginalCostOfFixedAssets)
            .WithMany()
            .HasForeignKey(nc => nc.OriginalCostOfFixedAssetsId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<NonCurrentAsset>()
            .HasOne(nc => nc.Wear)
            .WithMany()
            .HasForeignKey(nc => nc.WearId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<NonCurrentAsset>()
            .HasOne(nc => nc.InvestmentProperty)
            .WithMany()
            .HasForeignKey(nc => nc.InvestmentPropertyId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<NonCurrentAsset>()
            .HasOne(nc => nc.LongTermBiologicalAssets)
            .WithMany()
            .HasForeignKey(nc => nc.LongTermBiologicalAssetsId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<NonCurrentAsset>()
            .HasOne(nc => nc.LongTermFinancialInvestments)
            .WithMany()
            .HasForeignKey(nc => nc.LongTermFinancialInvestmentsId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<NonCurrentAsset>()
            .HasOne(nc => nc.OtherFinancialInvestments)
            .WithMany()
            .HasForeignKey(nc => nc.OtherFinancialInvestmentsId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<NonCurrentAsset>()
            .HasOne(nc => nc.LongTermReceivables)
            .WithMany()
            .HasForeignKey(nc => nc.LongTermReceivablesId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<NonCurrentAsset>()
            .HasOne(nc => nc.DeferredTaxAssets)
            .WithMany()
            .HasForeignKey(nc => nc.DeferredTaxAssetsId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<NonCurrentAsset>()
            .HasOne(nc => nc.OtherNonCurrentAssets)
            .WithMany()
            .HasForeignKey(nc => nc.OtherNonCurrentAssetsId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<NonCurrentAsset>()
            .HasOne(nc => nc.Sum)
            .WithMany()
            .HasForeignKey(nc => nc.SumId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<NonCurrentAssetsHeldForSaleDisposalGroup>()
            .HasOne(nc => nc.NonCurrentAssetsHeldForSale)
            .WithMany()
            .HasForeignKey(nc => nc.NonCurrentAssetsHeldForSaleId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<NonCurrentAssetsHeldForSaleDisposalGroup>()
            .HasOne(nc => nc.Balance)
            .WithMany()
            .HasForeignKey(nc => nc.BalanceId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<RegisteredCapital>()
            .HasOne(rc => rc.PaidInCapital)
            .WithMany()
            .HasForeignKey(rc => rc.PaidInCapitalId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<RegisteredCapital>()
            .HasOne(rc => rc.RevaluationReserve)
            .WithMany()
            .HasForeignKey(rc => rc.RevaluationReserveId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<RegisteredCapital>()
            .HasOne(rc => rc.AdditionalCapital)
            .WithMany()
            .HasForeignKey(rc => rc.AdditionalCapitalId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<RegisteredCapital>()
            .HasOne(rc => rc.ReserveCapital)
            .WithMany()
            .HasForeignKey(rc => rc.ReserveCapitalId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<RegisteredCapital>()
            .HasOne(rc => rc.RetainedEarnings)
            .WithMany()
            .HasForeignKey(rc => rc.RetainedEarningsId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<RegisteredCapital>()
            .HasOne(rc => rc.UnpaidCapital)
            .WithMany()
            .HasForeignKey(rc => rc.UnpaidCapitalId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<RegisteredCapital>()
            .HasOne(rc => rc.WithdrawnCapital)
            .WithMany()
            .HasForeignKey(rc => rc.WithdrawnCapitalId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<RegisteredCapital>()
            .HasOne(rc => rc.Sum)
            .WithMany()
            .HasForeignKey(rc => rc.SumId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<AssetTable>()
            .HasOne(at => at.NonCurrentAsset)
            .WithMany()
            .HasForeignKey(at => at.NonCurrentAssetId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<AssetTable>()
            .HasOne(at => at.CurrentAsset)
            .WithMany()
            .HasForeignKey(at => at.CurrentAssetId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<AssetTable>()
            .HasOne(at => at.NonCurrentAssetsHeldForSaleDisposalGroup)
            .WithMany()
            .HasForeignKey(at => at.NonCurrentAssetsHeldForSaleDisposalGroupId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<AssetTable>()
            .HasOne(at => at.RegisteredCapital)
            .WithMany()
            .HasForeignKey(at => at.RegisteredCapitalId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<AssetTable>()
            .HasOne(at => at.LongTermLiabilitiesAndProvision)
            .WithMany()
            .HasForeignKey(at => at.LongTermLiabilitiesAndProvisionId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<AssetTable>()
            .HasOne(at => at.CurrentLiabilitiesAndProvision)
            .WithMany()
            .HasForeignKey(at => at.CurrentLiabilitiesAndProvisionId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<AssetTable>()
            .HasOne(at => at.LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroup)
            .WithMany()
            .HasForeignKey(at => at.LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroupId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}