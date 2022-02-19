namespace Products.Service.Contracts
{

    public class ProductContract
    {
        public string ProductId { get; set; }
        public string ProductTitle { get; set; }
        public string ProductKind { get; set; }
        public string ProductFamily { get; set; }
        public string ShortDescription { get; set; }
        public string ShortTitle { get; set; }
        public string PreferredSkuId { get; set; }
        public IList<Image> Images { get; set; }
        public IList<AlternateId> AlternateIds { get; set; }
        public string DeveloperName { get; set; }
        public string SupportUri { get; set; }
        public string PublisherWebsiteUri { get; set; }
        public string PublisherName { get; set; }
        public string ProductDescription { get; set; }
        public string Category { get; set; }
        public bool HasAddOns { get; set; }
        public string ReleaseDate { get; set; }
        public string PackageFamilyName { get; set; }
        public IList<Video> Videos { get; set; }
        public BundleConfig BundleConfig { get; set; }
        public float AverageRating { get; set; }
        public int RatingCount { get; set; }
        public ContentRating ContentRating { get; set; }
        public EligibilityProperties EligibilityProperties { get; set; }
        public HardwareRequirements HardwareRequirements { get; set; }
        //public IList<SkuAvailability> SkuAvailabilities { get; set; }
        public IList<string> IncludedWithPassesProductIds { get; set; }
        public IList<string> Categories { get; set; }
        public IEnumerable<Capability> Capabilities { get; set; }
        public bool IsDownloadable { get; set; }
        //public ulong MaxInstallSize { get; set; }
        public IDictionary<string, string> PackageCapabilities { get; set; }
        public ProductProperties Properties { get; set; }
        public IList<RelatedProduct> RelatedProducts { get; set; }
        public SpecificPrices SpecificPrices { get; set; }
        public MovieProperties MovieProperties { get; set; }
        public TvProperties TvProperties { get; set; }
        public HardwareProperties HardwareProperties { get; set; }
        public bool IsPreOrder { get; set; }
        public IList<Badge> Badges { get; set; }
        public IList<string> Editions { get; set; }
        public IList<string> BundlesBySeed { get; set; }
        public IList<string> AvailableOn { get; set; }
        public GenericMetadata GenericMetadata { get; set; }
        public bool? IsBaseGameFree { get; set; }
        public XCloudProperties XCloudProperties { get; set; }
        public string PublisherId { get; set; }

        public ProductContract()
            : this(null, null, null, null, null, null, null, null, null, null, null, null, null)
        {
        }

        public ProductContract(
            IList<Image> images = null,
            IList<Video> videos = null,
            IList<SkuAvailability> skuAvailabilities = null,
            IList<AlternateId> alternateIds = null,
            IList<string> includedWithPassesProductIds = null,
            IList<string> categories = null,
            IEnumerable<Capability> capabilities = null,
            IDictionary<string, string> packageCapabilities = null,
            IList<RelatedProduct> relatedProducts = null,
            IList<Badge> badges = null,
            IList<string> editions = null,
            IList<string> bundlesBySeed = null,
            IList<string> availableOn = null)
        {
            Images = images ?? new List<Image>();
            Videos = videos ?? new List<Video>();
            //SkuAvailabilities = skuAvailabilities ?? new List<SkuAvailability>();
            AlternateIds = alternateIds ?? new List<AlternateId>();
            IncludedWithPassesProductIds = includedWithPassesProductIds ?? new List<string>();
            Categories = categories ?? new List<string>();
            Capabilities = capabilities ?? new List<Capability>();
            PackageCapabilities = packageCapabilities ?? new Dictionary<string, string>();
            RelatedProducts = relatedProducts ?? new List<RelatedProduct>();
            Badges = badges ?? new List<Badge>();
            Editions = editions ?? new List<string>();
            BundlesBySeed = bundlesBySeed ?? new List<string>();
            AvailableOn = availableOn ?? new List<string>();
        }
    }
}
