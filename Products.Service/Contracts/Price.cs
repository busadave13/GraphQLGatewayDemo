namespace Products.Service.Contracts
{
    public class Price
    {
        public string SkuId { get; set; }
        public string AvailabilityId { get; set; }
        public float ListPrice { get; set; }
        public float MSRP { get; set; }
        public float DiscountPercentage { get; set; }
        public string CurrencyCode { get; set; }
        public IList<Remediation> Remediations { get; }
        public string AffirmationId { get; set; }
        public PriceEligibilityInfo PriceEligibilityInfo { get; set; }
        public IList<string> AvailabilityActions { get; set; }
        public DateTime? EndDate { get; set; }
        public bool HasXPriceOffer { get; set; }

        public Price()
            : this(null, null)
        {
        }

        public Price(
            IList<string> availabilityActions = null,
            IList<Remediation> remediations = null)
        {
            AvailabilityActions = availabilityActions ?? new List<string>();
            Remediations = remediations ?? new List<Remediation>();
        }
    }
}