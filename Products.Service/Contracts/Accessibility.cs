namespace Products.Service.Contracts
{
    public class Accessibility
    {
        public Uri Uri { get; set; }
        public IDictionary<string, GenericMetadataStatusEnum> GamePlay { get; set; }
        public IDictionary<string, GenericMetadataStatusEnum> Audio { get; set; }
        public IDictionary<string, GenericMetadataStatusEnum> Visual { get; set; }
        public IDictionary<string, GenericMetadataStatusEnum> Input { get; set; }
    }
}