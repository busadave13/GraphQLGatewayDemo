namespace Products.Service.Contracts
{
    public class Trailer
    {
        public string TrailerName { get; set; }
        public System.Uri Uri { get; set; }
        public string DeliveryFormat { get; set; }
        public string ResolutionFormat { get; set; }
    }
}