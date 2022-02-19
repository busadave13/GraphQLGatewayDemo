namespace Products.Service.Contracts
{
    public class BundleConfig
    {
        public string BundleId { get; set; }
        public string RenderHint { get; set; }
        public IList<BundleSlot> BundleSlots { get; }
        public string BundleTitle { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }

        public BundleConfig()
            : this(null)
        {
        }

        public BundleConfig(IList<BundleSlot> bundleSlots = null)
        {
            BundleSlots = bundleSlots ?? new List<BundleSlot>();
        }
    }
}