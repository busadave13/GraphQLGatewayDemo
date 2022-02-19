namespace Products.Service.Contracts
{
    public class FulfillmentData
    {
        public string DistributionRight { get; set; }
        public VideoAttributes VideoAttributes { get; set; }
        public string WuCategoryId { get; set; }
        public int? AcquisitionPeriodInHours { get; set; }
        public int? ViewingPeriodInHours { get; set; }
    }
}