namespace Products.Service.Contracts
{
    public class Inclusion
    {
        public IDictionary<string, GenericMetadataStatusEnum> Approachability { get; set; }
        public Globalization Globalization { get; set; }
        public IDictionary<string, GenericMetadataStatusEnum> Representation { get; set; }
        public IDictionary<string, GenericMetadataStatusEnum> GamingAwards { get; set; }
        public IDictionary<string, GenericMetadataStatusEnum> MainCharacterRepresentation { get; set; }
        public IDictionary<string, GenericMetadataStatusEnum> PlayerExpression { get; set; }
    }
}