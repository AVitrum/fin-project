namespace FInProject.Models;

public class CurrentLiabilitiesAndProvision : BaseModel
{
    public CurrentLiabilitiesAndProvision() : base("III. Поточні зобов'язання та забезпечення")
    {
        ShortTermBankLoans = new Asset(1600, "Короткострокові кредити банків");
        CurrentAccountsPayableLongTermLiabilities = new Asset(1610, "Поточна кредиторська заборгованість за довгостроковими зобов'язаннями");
        CurrentAccountsPayableGoodsAndServices = new Asset(1615, "Поточна кредиторська заборгованість за товари, роботи, послуги");
        CurrentAccountsPayableBudgetSettlements = new Asset(1620, "Поточна кредиторська заборгованість за розрахунками з бюджетом");
        CurrentAccountsPayableIncludingIncomeTax = new Asset(1621, "у тому числі з податку на прибуток");
        CurrentAccountsPayableInsuranceSettlements = new Asset(1625, "розрахунками зі страхування");
        CurrentAccountsPayableWageSettlements = new Asset(1630, "розрахунками з оплати праці");
        CurrentProvisions = new Asset(1660, "Поточні забезпечення");
        DeferredIncome = new Asset(1665, "Доходи майбутніх періодів");
        OtherCurrentLiabilities = new Asset(1690, "Інші поточні зобов'язання");
        Sum = new Asset(1695, "Усього за розділом III");
    }

    public Guid ShortTermBankLoansId { get; set; }
    public Asset ShortTermBankLoans { get; set; }

    public Guid CurrentAccountsPayableLongTermLiabilitiesId { get; set; }
    public Asset CurrentAccountsPayableLongTermLiabilities { get; set; }

    public Guid CurrentAccountsPayableGoodsAndServicesId { get; set; }
    public Asset CurrentAccountsPayableGoodsAndServices { get; set; }

    public Guid CurrentAccountsPayableBudgetSettlementsId { get; set; }
    public Asset CurrentAccountsPayableBudgetSettlements { get; set; }

    public Guid CurrentAccountsPayableIncludingIncomeTaxId { get; set; }
    public Asset CurrentAccountsPayableIncludingIncomeTax { get; set; }

    public Guid CurrentAccountsPayableInsuranceSettlementsId { get; set; }
    public Asset CurrentAccountsPayableInsuranceSettlements { get; set; }

    public Guid CurrentAccountsPayableWageSettlementsId { get; set; }
    public Asset CurrentAccountsPayableWageSettlements { get; set; }

    public Guid CurrentProvisionsId { get; set; }
    public Asset CurrentProvisions { get; set; }

    public Guid DeferredIncomeId { get; set; }
    public Asset DeferredIncome { get; set; }

    public Guid OtherCurrentLiabilitiesId { get; set; }
    public Asset OtherCurrentLiabilities { get; set; }

    public Guid SumId { get; set; }
    public Asset Sum { get; set; }
}