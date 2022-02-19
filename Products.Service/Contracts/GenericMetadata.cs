namespace Products.Service.Contracts
{
    public enum GenericMetadataStatusEnum
    {
        SetTrue = 0,   // To be used if the publisher has selected the feature
        SetFalse = 1,  // To be used if the publisher has unselected the feature
        NotSet = 3,    // To be used if there is no response from publisher for the feature 
        DoNotShow = 4, // To be used if the feature should not be shown due to market restrictions.
    }

    public class GenericMetadata
    {
        public IDictionary<string, GenericMetadataStatusEnum> CloudGaming { get; set; }
        public Inclusion Inclusion { get; set; }
        public SupportedLanguages SupportedLanguages { get; set; }
        public CompareEditions CompareEditions { get; set; }
        public IDictionary<string, GenericMetadataStatusEnum> TechnicalCapabilities { get; set; }
        public Accessibility Accessibility { get; set; }
    }
}