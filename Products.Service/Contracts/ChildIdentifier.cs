namespace Products.Service.Contracts
{
    public class ChildIdentifier
    {
        public string ProductId { get; set; }
        public string SkuId { get; set; }
        public string AvailabilityId { get; set; }
        public string Tag { get; set; }
        public int DisplayRank { get; set; }
        public bool AutoSelected { get; set; }
        public bool DefaultSelected { get; set; }
    }
}