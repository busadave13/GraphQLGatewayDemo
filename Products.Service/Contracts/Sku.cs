namespace Products.Service.Contracts
{
    public class Sku
    {
        public string AdditionalLicenseTerms { get; set; }
        public IList<BundledSku> BundledSkus { get; }
        public string Copyright { get; set; }
        public IList<string> Features { get; set; }
        public string FirstAvailableDate { get; set; }
        public string FulfillmentType { get; set; }
        public IList<Image> Images { get; set; }
        public string InstallationTerms { get; set; }
        public string InventoryControlSkuId { get; set; }
        public bool IsPreOrder { get; set; }
        public bool IsRepurchasable { get; set; }
        public IList<string> Languages { get; }
        public ulong MaxDownloadSizeInBytes { get; set; }
        public ulong MaxInstallSizeInBytes { get; set; }
        public IList<Package> Packages { get; set; }
        public string PrivacyPolicyUri { get; set; }
        public RecurrencePolicy RecurrencePolicy { get; set; }
        public string ReleaseNotes { get; set; }
        public string SkuDescription { get; set; }
        public SkuMovieProperties SkuMovieProperties { get; set; }
        public string SkuId { get; set; }
        public string SkuTitle { get; set; }
        public string SkuButtonTitle { get; set; }
        public string SkuType { get; set; }
        public int? MaxAllowedQuantity { get; set; }
        public int? MinAllowedQuantity { get; set; }

        public Sku()
            : this(null, null, null, null, null)
        {
        }

        public Sku(
            IList<BundledSku> bundledSkus = null,
            IList<string> languages = null,
            IList<Package> packages = null,
            IList<string> features = null,
            IList<Image> images = null)
        {
            BundledSkus = bundledSkus ?? new List<BundledSku>();
            Languages = languages ?? new List<string>();
            Packages = packages ?? new List<Package>();
            Features = features ?? new List<string>();
            Images = images ?? new List<Image>();
        }
    }
}