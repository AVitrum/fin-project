namespace FInProject.Models;

public class LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroup : BaseModel
{
    public LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroup() : base("ІV. Зобов'язання, пов'язані з необоротними активами, утримуваними для продажу, та групами вибуття")
    {
        LiabilitiesRelatedToNonCurrentAssetsHeldForSale = new Asset(1700, "Зобов'язання, пов'язані з необоротними активами");
        Balance = new Asset(1900, "Баланс");
    }

    public Guid LiabilitiesRelatedToNonCurrentAssetsHeldForSaleId { get; set; }
    public Asset LiabilitiesRelatedToNonCurrentAssetsHeldForSale { get; set; }

    public Guid BalanceId { get; set; }
    public Asset Balance { get; set; }
}