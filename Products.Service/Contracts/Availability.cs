namespace Products.Service.Contracts
{
    public enum AvailabilityActions
    {
        Default = 0,
        Purchase = 1,
        Browse = 2,
        Details = 3,
        Gift = 4,
        Fulfill = 5,
        Redeem = 6,
    }

    public class Availability
    {
        public string AvailabilityId { get; set; }
        public IList<AvailabilityActions> Actions { get; }
        public IList<string> AllowedPlatforms { get; }
        public SkuAvailabilityPrice Price { get; set; }
        public bool RemediationRequired { get; set; }
        public IList<Remediation> Remediations { get; }
        public string Affirmationid { get; set; }
        public DateTime? PreOrderReleaseDate { get; set; }
        public IList<string> MerchandisingTags { get; }
        public FreePlay FreePlay { get; set; }
        public Duration PromotionalDuration { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? Startdate { get; set; }
        public PIFilter PIFilter { get; set; }
        public string BundleTag { get; set; }
        public int DisplayRank { get; set; }
        public bool HasXPriceOffer { get; set; }

        public Availability()
            : this(null, null, null, null)
        {
        }

        public Availability(
            IList<AvailabilityActions> actions = null,
            IList<string> allowedPlatforms = null,
            IList<Remediation> remediations = null,
            IList<string> merchandisingTags = null)
        {
            Actions = actions ?? new List<AvailabilityActions>();
            AllowedPlatforms = allowedPlatforms ?? new List<string>();
            Remediations = remediations ?? new List<Remediation>();
            MerchandisingTags = merchandisingTags ?? new List<string>();
        }
    }
}