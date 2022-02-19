namespace Products.Service.Contracts
{
    public class SkuMovieProperties
    {
        public FulfillmentData FulfillmentData { get; set; }
        public bool HasDisneyMetadata { get; set; }
        public IList<VideoInstance> VideoInstances { get; set; }

        public SkuMovieProperties() : this(null)
        {
        }

        public SkuMovieProperties(IList<VideoInstance> videoInstances = null)
        {
            VideoInstances = videoInstances ?? new List<VideoInstance>();
        }
    }
}