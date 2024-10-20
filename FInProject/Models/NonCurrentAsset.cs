namespace FInProject.Models;

public class NonCurrentAsset : BaseModel
{
    public NonCurrentAsset() : base("I. Необоротні активи")
    {
        IntangibleAssets = new Asset(1000, "Нематеріальні активи");
        OriginalCost = new Asset(1001, "первісна вартість");
        AccumulatedDepreciation = new Asset(1002, "накопичена амортизація");
        UncompletedCapitalInvestments = new Asset(1005, "Незавершені капітальні інвестиції");
        FixedAssets = new Asset(1010, "Основні засоби");
        OriginalCostOfFixedAssets = new Asset(1011, "первісна вартість");
        Wear = new Asset(1012, "Знос");
        InvestmentProperty = new Asset(1015, "Інвестиційна нерухомість");
        LongTermBiologicalAssets = new Asset(1020, "Довгострокові біологічні активи");
        LongTermFinancialInvestments = new Asset(1030, "Довгострокові фінансові інвестиції, які обліковуються за методом участі в капіталі інших підприємств");
        OtherFinancialInvestments = new Asset(1035, "інші фінансові інвестиції");
        LongTermReceivables = new Asset(1040, "Довгострокова дебіторська заборгованість");
        DeferredTaxAssets = new Asset(1045, "Відстрочені податкові активи");
        OtherNonCurrentAssets = new Asset(1090, "Інші необоротні активи");
        Sum = new Asset(1095, "Усього за розділом І");
    }

    public Guid IntangibleAssetsId { get; set; }
    public Asset IntangibleAssets { get; set; }

    public Guid OriginalCostId { get; set; }
    public Asset OriginalCost { get; set; }

    public Guid AccumulatedDepreciationId { get; set; }
    public Asset AccumulatedDepreciation { get; set; }

    public Guid UncompletedCapitalInvestmentsId { get; set; }
    public Asset UncompletedCapitalInvestments { get; set; }

    public Guid FixedAssetsId { get; set; }
    public Asset FixedAssets { get; set; }

    public Guid OriginalCostOfFixedAssetsId { get; set; }
    public Asset OriginalCostOfFixedAssets { get; set; }

    public Guid WearId { get; set; }
    public Asset Wear { get; set; }

    public Guid InvestmentPropertyId { get; set; }
    public Asset InvestmentProperty { get; set; }

    public Guid LongTermBiologicalAssetsId { get; set; }
    public Asset LongTermBiologicalAssets { get; set; }

    public Guid LongTermFinancialInvestmentsId { get; set; }
    public Asset LongTermFinancialInvestments { get; set; }

    public Guid OtherFinancialInvestmentsId { get; set; }
    public Asset OtherFinancialInvestments { get; set; }

    public Guid LongTermReceivablesId { get; set; }
    public Asset LongTermReceivables { get; set; }

    public Guid DeferredTaxAssetsId { get; set; }
    public Asset DeferredTaxAssets { get; set; }

    public Guid OtherNonCurrentAssetsId { get; set; }
    public Asset OtherNonCurrentAssets { get; set; }

    public Guid SumId { get; set; }
    public Asset Sum { get; set; }
}