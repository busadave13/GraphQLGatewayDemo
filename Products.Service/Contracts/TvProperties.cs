namespace Products.Service.Contracts
{
    public class TvProperties
    {
        public IList<string> TvGenres { get; }
        public int? ExpectedNumberOfEpisodes { get; set; }
        public bool? IsComplete { get; set; }
        public string FirstEpisodeId { get; set; }
        public string PresaleFulfillmentDate { get; set; }
        public string ComingSoonPurchaseDate { get; set; }
        public string OriginalPublicationDate { get; set; }
        public IList<Network> Networks { get; }
        public int? TotalPublishedNumberOfSeasons { get; set; }
        public IList<TVParentProduct> TvParentProducts { get; }

        public TvProperties()
            : this(null, null, null)
        {
        }

        public TvProperties(IList<string> tvGenres = null, IList<Network> networks = null, IList<TVParentProduct> parents = null)
        {
            TvGenres = tvGenres ?? new List<string>();
            Networks = networks ?? new List<Network>();
            TvParentProducts = parents ?? new List<TVParentProduct>();
        }
    }
}