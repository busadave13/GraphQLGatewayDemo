namespace Products.Service.Contracts
{
    public class BundleSlot
    {
        public string SlotId { get; set; }
        public string RenderHint { get; set; }
        public int DisplayRank { get; set; }
        public int Maximum { get; set; }
        public int Minimum { get; set; }
        public IList<ChildIdentifier> ChildIdentifiers { get; }
        public string SlotTitle { get; set; }

        public BundleSlot()
            : this(null)
        {
        }

        public BundleSlot(IList<ChildIdentifier> childIdentifiers = null)
        {
            ChildIdentifiers = childIdentifiers ?? new List<ChildIdentifier>();
        }
    }
}