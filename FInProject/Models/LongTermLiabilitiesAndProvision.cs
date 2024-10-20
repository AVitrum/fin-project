namespace FInProject.Models;

public class LongTermLiabilitiesAndProvision : BaseModel
{
    public LongTermLiabilitiesAndProvision() : base("II. Довгострокові зобов'язання і забезпечення")
    {
        DeferredTaxLiabilities = new Asset(1500, "Відстрочені податкові зобов'язання");
        LongTermBankLoans = new Asset(1510, "Довгострокові кредити банків");
        OtherLongTermLiabilities = new Asset(1515, "Інші довгострокові зобов'язання");
        LongTermProvisions = new Asset(1520, "Довгострокові забезпечення");
        TargetFinancing = new Asset(1525, "Цільове фінансування");
        Sum = new Asset(1595, "Усього за розділом II");
    }

    public Guid DeferredTaxLiabilitiesId { get; set; }
    public Asset DeferredTaxLiabilities { get; set; }

    public Guid LongTermBankLoansId { get; set; }
    public Asset LongTermBankLoans { get; set; }

    public Guid OtherLongTermLiabilitiesId { get; set; }
    public Asset OtherLongTermLiabilities { get; set; }

    public Guid LongTermProvisionsId { get; set; }
    public Asset LongTermProvisions { get; set; }

    public Guid TargetFinancingId { get; set; }
    public Asset TargetFinancing { get; set; }

    public Guid SumId { get; set; }
    public Asset Sum { get; set; }
}