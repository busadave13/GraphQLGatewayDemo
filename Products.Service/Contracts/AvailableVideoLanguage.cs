namespace Products.Service.Contracts
{
    public class AvailableVideoLanguage
    {
        public string AudioLocale { get; set; }
        public IList<OverlaysProperty> OverlaysProperties { get; set; } = new List<OverlaysProperty>();
        public string PrimaryResolutionFormat { get; set; }
        public string AudioLanguage { get; set; }
        public string BurntInSubtitlesLocale { get; set; }
        public string BurntInSubtitlesLanguage { get; set; }
    }
}