namespace Products.Service.Contracts
{
    public class ContentRating
    {
        public Uri RatingImageUri { get; set; }
        public Uri RatingImageLinkUri { get; set; }
        public string RatingBoardName { get; set; }
        public string RatingDescription { get; set; }
        public string Rating { get; set; }
        public string ShortName { get; set; }
        public int RatingAge { get; set; }
        public string RatingId { get; set; }
        public IList<string> Descriptors { get; }
        public IList<string> Disclaimers { get; }
        public IList<string> InteractiveElements { get; }

        public ContentRating()
            : this(null, null, null)
        {
        }

        public ContentRating(
            IList<string> descriptors = null,
            IList<string> disclaimers = null,
            IList<string> interactiveElements = null)
        {
            Descriptors = descriptors ?? new List<string>();
            Disclaimers = disclaimers ?? new List<string>();
            InteractiveElements = interactiveElements ?? new List<string>();
        }
    }
}