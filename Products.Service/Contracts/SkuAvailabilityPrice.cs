namespace Products.Service.Contracts
{
    public class SkuAvailabilityPrice
    {
        public float ListPrice { get; set; }
        public float MSRP { get; set; }
        public string CurrencyCode { get; set; }
        public IList<Remediation> Remediations { get; }
        public bool IsPIRequired { get; set; }
        public string TaxType { get; set; }

        public SkuAvailabilityPrice()
            : this(null)
        {
        }

        public SkuAvailabilityPrice(IList<Remediation> remediations = null)
        {
            Remediations = remediations ?? new List<Remediation>();
        }

        public SkuAvailabilityPrice Clone()
        {
            var remediations = new List<Remediation>(Remediations.Count);
            foreach (var remediation in Remediations)
            {
                remediations.Add(new Remediation()
                {
                    BigId = remediation.BigId,
                    RemediationId = remediation.RemediationId,
                    Type = remediation.Type,
                });
            }

            return new SkuAvailabilityPrice(remediations)
            {
                CurrencyCode = CurrencyCode,
                IsPIRequired = IsPIRequired,
                TaxType = TaxType,
                ListPrice = ListPrice,
                MSRP = MSRP,
            };
        }
    }
}