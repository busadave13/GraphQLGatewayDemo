namespace Products.Service.Contracts
{
    public class MovieProperties
    {
        public IList<Contributor> Contributors { get; }
        public IList<Trailer> Trailers { get; }
        public IList<Studio> Studios { get; }
        public IList<string> MovieGenres { get; }
        public FulfillmentData FulfillmentData { get; set; }
        public IList<VideoInstance> VideoInstances { get; }
        public int DurationInSeconds { get; set; }
        public bool IsVideoBundle { get; set; }
        public string VideoType { get; set; }
        public IList<BundleProduct> BundleProducts { get; }
        public IList<MovieAward> MovieAwards { get; }

        public MovieProperties()
            : this(null, null, null, null, null, null, null)
        {
        }

        public MovieProperties(
            IList<Contributor> contributors = null,
            IList<Trailer> trailers = null,
            IList<Studio> studios = null,
            IList<string> movieGenres = null,
            IList<VideoInstance> videoInstances = null,
            IList<BundleProduct> bundleProducts = null,
            IList<MovieAward> movieAwards = null)
        {
            Contributors = contributors ?? new List<Contributor>();
            Trailers = trailers ?? new List<Trailer>();
            Studios = studios ?? new List<Studio>();
            MovieGenres = movieGenres ?? new List<string>();
            VideoInstances = videoInstances ?? new List<VideoInstance>();
            BundleProducts = bundleProducts ?? new List<BundleProduct>();
            MovieAwards = movieAwards ?? new List<MovieAward>();
        }
    }
}