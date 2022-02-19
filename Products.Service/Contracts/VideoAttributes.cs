namespace Products.Service.Contracts
{
    public class VideoAttributes
    {
        public IList<AvailableVideoLanguage> AvailableVideoLanguages { get; set; } = new List<AvailableVideoLanguage>();
        public string PrimaryResolutionFormat { get; set; }
    }
}