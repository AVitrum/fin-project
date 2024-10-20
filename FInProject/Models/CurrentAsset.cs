namespace FInProject.Models;

public class CurrentAsset : BaseModel
{
    public CurrentAsset() : base("II. Оборотні активи")
    {
        Inventory = new Asset(1100, "Запаси");
        CurrentBiologicalAssets = new Asset(1110, "Поточні біологічні активи");
        ReceivablesForGoodsAndServices = new Asset(1125, "Дебіторська заборгованість за продукцію, товари, роботи, послуги");
        ReceivablesForSettlementsAdvancesIssued = new Asset(1130, "Дебіторська заборгованість за розрахунками: за виданими авансами");
        ReceivablesForSettlementsBudget = new Asset(1135, "Дебіторська заборгованість з бюджетом");
        ReceivablesForSettlementsIncludingIncomeTax = new Asset(1136, "у тому числі з податку на прибуток");
        OtherCurrentReceivables = new Asset(1155, "Інша поточна дебіторська заборгованість");
        CurrentFinancialInvestments = new Asset(1160, "Поточні фінансові інвестиції");
        CashAndCashEquivalents = new Asset(1165, "Гроші та їх еквіваленти");
        PrepaidExpenses = new Asset(1170, "Витрати майбутніх періодів");
        OtherCurrentAssets = new Asset(1190, "Інші оборотні активи");
        Sum = new Asset(1195, "Усього за розділом II");
    }

    public Guid InventoryId { get; set; }
    public Asset Inventory { get; set; }

    public Guid CurrentBiologicalAssetsId { get; set; }
    public Asset CurrentBiologicalAssets { get; set; }

    public Guid ReceivablesForGoodsAndServicesId { get; set; }
    public Asset ReceivablesForGoodsAndServices { get; set; }

    public Guid ReceivablesForSettlementsAdvancesIssuedId { get; set; }
    public Asset ReceivablesForSettlementsAdvancesIssued { get; set; }

    public Guid ReceivablesForSettlementsBudgetId { get; set; }
    public Asset ReceivablesForSettlementsBudget { get; set; }

    public Guid ReceivablesForSettlementsIncludingIncomeTaxId { get; set; }
    public Asset ReceivablesForSettlementsIncludingIncomeTax { get; set; }

    public Guid OtherCurrentReceivablesId { get; set; }
    public Asset OtherCurrentReceivables { get; set; }

    public Guid CurrentFinancialInvestmentsId { get; set; }
    public Asset CurrentFinancialInvestments { get; set; }

    public Guid CashAndCashEquivalentsId { get; set; }
    public Asset CashAndCashEquivalents { get; set; }

    public Guid PrepaidExpensesId { get; set; }
    public Asset PrepaidExpenses { get; set; }

    public Guid OtherCurrentAssetsId { get; set; }
    public Asset OtherCurrentAssets { get; set; }

    public Guid SumId { get; set; }
    public Asset Sum { get; set; }
}