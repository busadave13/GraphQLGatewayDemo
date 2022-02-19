namespace Products.Service.Contracts
{
    public class Package
    {
        public string ContentId { get; set; }
        public string KeyId { get; set; }
        public bool? SupportsIntelligentDelivery { get; set; }
        public bool? SupportsInstallFeatures { get; set; }
    }
}