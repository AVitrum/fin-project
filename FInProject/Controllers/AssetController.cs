using FInProject.Data;
using FInProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FInProject.Controllers;

public class AssetController : Controller
{
    private readonly ApplicationDbContext _context;

    public AssetController(ApplicationDbContext context)
    {
        _context = context;
    }

    private async Task<AssetTable> FindAssetTableWithAllDataByIdAsync(Guid id)
    {
        AssetTable? assetTable = await _context.AssetTables
            .FirstOrDefaultAsync(at => at.Id == id);

        if (assetTable == null)
        {
            throw new Exception("AssetTable not found");
        }

        assetTable.NonCurrentAsset = await _context.NonCurrentAssets
            .Include(nc => nc.IntangibleAssets)
            .Include(nc => nc.OriginalCost)
            .Include(nc => nc.AccumulatedDepreciation)
            .Include(nc => nc.UncompletedCapitalInvestments)
            .Include(nc => nc.FixedAssets)
            .Include(nc => nc.OriginalCostOfFixedAssets)
            .Include(nc => nc.Wear)
            .Include(nc => nc.InvestmentProperty)
            .Include(nc => nc.LongTermBiologicalAssets)
            .Include(nc => nc.LongTermFinancialInvestments)
            .Include(nc => nc.OtherFinancialInvestments)
            .Include(nc => nc.LongTermReceivables)
            .Include(nc => nc.DeferredTaxAssets)
            .Include(nc => nc.OtherNonCurrentAssets)
            .Include(nc => nc.Sum)
            .FirstOrDefaultAsync(nc => nc.Id == assetTable.NonCurrentAssetId) ?? throw new Exception();

        assetTable.CurrentAsset = await _context.CurrentAssets
            .Include(ca => ca.Inventory)
            .Include(ca => ca.CurrentBiologicalAssets)
            .Include(ca => ca.ReceivablesForGoodsAndServices)
            .Include(ca => ca.ReceivablesForSettlementsAdvancesIssued)
            .Include(ca => ca.ReceivablesForSettlementsBudget)
            .Include(ca => ca.ReceivablesForSettlementsIncludingIncomeTax)
            .Include(ca => ca.OtherCurrentReceivables)
            .Include(ca => ca.CurrentFinancialInvestments)
            .Include(ca => ca.CashAndCashEquivalents)
            .Include(ca => ca.PrepaidExpenses)
            .Include(ca => ca.OtherCurrentAssets)
            .Include(ca => ca.Sum)
            .FirstOrDefaultAsync(ca => ca.Id == assetTable.CurrentAssetId) ?? throw new Exception();

        assetTable.NonCurrentAssetsHeldForSaleDisposalGroup = await _context.NonCurrentAssetsHeldForSaleDisposalGroups
            .Include(nc => nc.NonCurrentAssetsHeldForSale)
            .Include(nc => nc.Balance)
            .FirstOrDefaultAsync(nc => nc.Id == assetTable.NonCurrentAssetsHeldForSaleDisposalGroupId) ?? throw new Exception();

        assetTable.RegisteredCapital = await _context.RegisteredCapitals
            .Include(rc => rc.PaidInCapital)
            .Include(rc => rc.RevaluationReserve)
            .Include(rc => rc.AdditionalCapital)
            .Include(rc => rc.ReserveCapital)
            .Include(rc => rc.RetainedEarnings)
            .Include(rc => rc.UnpaidCapital)
            .Include(rc => rc.WithdrawnCapital)
            .Include(rc => rc.Sum)
            .FirstOrDefaultAsync(rc => rc.Id == assetTable.RegisteredCapitalId) ?? throw new Exception();

        assetTable.LongTermLiabilitiesAndProvision = await _context.LongTermLiabilitiesAndProvisions
            .Include(lt => lt.DeferredTaxLiabilities)
            .Include(lt => lt.LongTermBankLoans)
            .Include(lt => lt.OtherLongTermLiabilities)
            .Include(lt => lt.LongTermProvisions)
            .Include(lt => lt.TargetFinancing)
            .Include(lt => lt.Sum)
            .FirstOrDefaultAsync(lt => lt.Id == assetTable.LongTermLiabilitiesAndProvisionId) ?? throw new Exception();

        assetTable.CurrentLiabilitiesAndProvision = await _context.CurrentLiabilitiesAndProvisions
            .Include(cl => cl.ShortTermBankLoans)
            .Include(cl => cl.CurrentAccountsPayableLongTermLiabilities)
            .Include(cl => cl.CurrentAccountsPayableGoodsAndServices)
            .Include(cl => cl.CurrentAccountsPayableBudgetSettlements)
            .Include(cl => cl.CurrentAccountsPayableIncludingIncomeTax)
            .Include(cl => cl.CurrentAccountsPayableInsuranceSettlements)
            .Include(cl => cl.CurrentAccountsPayableWageSettlements)
            .Include(cl => cl.CurrentProvisions)
            .Include(cl => cl.DeferredIncome)
            .Include(cl => cl.OtherCurrentLiabilities)
            .Include(cl => cl.Sum)
            .FirstOrDefaultAsync(cl => cl.Id == assetTable.CurrentLiabilitiesAndProvisionId) ?? throw new Exception();

        assetTable.LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroup = await _context.LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroups
            .Include(lr => lr.LiabilitiesRelatedToNonCurrentAssetsHeldForSale)
            .Include(lr => lr.Balance)
            .FirstOrDefaultAsync(lr => lr.Id == assetTable.LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroupId) ?? throw new Exception();
        
        return assetTable;
    }

    public async Task<IActionResult> Index()
    {
        List<AssetTable> assetTables = await _context.AssetTables.ToListAsync();

        return View(assetTables);
    }

    public async Task<IActionResult> Details(Guid id)
    {
        AssetTable assetTable = await FindAssetTableWithAllDataByIdAsync(id);
        return View(assetTable);
    }
    
    public IActionResult Create()
    {
        AssetTable assetTable = new AssetTable();
        return View(assetTable);
    }

    [HttpPost]
    public async Task<IActionResult> Create(AssetTable assetTable)
    {
        if (ModelState.IsValid)
        {
            _context.Add(assetTable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        return View(assetTable);
    }
}