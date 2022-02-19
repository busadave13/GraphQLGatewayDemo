namespace Products.Service.Contracts
{
    public class SkuAvailability
    {        
        public Sku Sku { get; set; }
        public IList<Availability> Availabilities { get; }

        public SkuAvailability()
            : this(null)
        {
        }

        public SkuAvailability(IList<Availability> availabilities = null)
        {
            Availabilities = availabilities ?? new List<Availability>();
        }
    }
}