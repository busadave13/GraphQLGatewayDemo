namespace Products.Service.Contracts
{
    public class CompareEditions
    {
        public IList<Image> UpsellImages { get; set; }
        public IList<Image> BackgroundImages { get; set; }
        public IList<string> UpsellText { get; set; }
        public Duration EarlyAccess { get; set; }
    }
}