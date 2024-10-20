namespace FInProject.Models;

public class NonCurrentAssetsHeldForSaleDisposalGroup : BaseModel
{
    public NonCurrentAssetsHeldForSaleDisposalGroup() : base("III. Необоротні активи, утримувані для продажу, та групи вибуття")
    {
        NonCurrentAssetsHeldForSale = new Asset(1200, "Необоротні активи, утримувані для продажу");
        Balance = new Asset(1300, "Баланс");
    }

    public Guid NonCurrentAssetsHeldForSaleId { get; set; }
    public Asset NonCurrentAssetsHeldForSale { get; set; }

    public Guid BalanceId { get; set; }
    public Asset Balance { get; set; }
}