namespace Products.Service.Contracts
{
    public class Globalization
    {
        public string DevelopedIn { get; set; }
        public IDictionary<string, GenericMetadataStatusEnum> TechnicalNeeds { get; set; }
    }
}