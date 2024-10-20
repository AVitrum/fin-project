namespace FInProject.Models;

public class AssetTable
{
    public AssetTable()
    {
        NonCurrentAsset = new NonCurrentAsset();
        CurrentAsset = new CurrentAsset();
        NonCurrentAssetsHeldForSaleDisposalGroup = new NonCurrentAssetsHeldForSaleDisposalGroup();
        RegisteredCapital = new RegisteredCapital();
        LongTermLiabilitiesAndProvision = new LongTermLiabilitiesAndProvision();
        CurrentLiabilitiesAndProvision = new CurrentLiabilitiesAndProvision();
        LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroup = new LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroup();
    }

    public Guid Id { get; set; }

    public Guid NonCurrentAssetId { get; set; }
    public NonCurrentAsset NonCurrentAsset { get; set; }

    public Guid CurrentAssetId { get; set; }
    public CurrentAsset CurrentAsset { get; set; }

    public Guid NonCurrentAssetsHeldForSaleDisposalGroupId { get; set; }
    public NonCurrentAssetsHeldForSaleDisposalGroup NonCurrentAssetsHeldForSaleDisposalGroup { get; set; }

    public Guid RegisteredCapitalId { get; set; }
    public RegisteredCapital RegisteredCapital { get; set; }

    public Guid LongTermLiabilitiesAndProvisionId { get; set; }
    public LongTermLiabilitiesAndProvision LongTermLiabilitiesAndProvision { get; set; }

    public Guid CurrentLiabilitiesAndProvisionId { get; set; }
    public CurrentLiabilitiesAndProvision CurrentLiabilitiesAndProvision { get; set; }

    public Guid LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroupId { get; set; }
    public LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroup LiabilitiesRelatedToNonCurrentAssetsHeldForSaleDisposalGroup { get; set; }
}