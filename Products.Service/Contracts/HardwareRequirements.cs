namespace Products.Service.Contracts
{
    public class HardwareRequirements
    {
        public IList<HardwareSpecification> Minimum { get; }
        public IList<HardwareSpecification> Recommended { get; }

        public HardwareRequirements()
            : this(null, null)
        {
        }

        public HardwareRequirements(
            IList<HardwareSpecification> minimum = null,
            IList<HardwareSpecification> recommended = null)
        {
            Minimum = minimum ?? new List<HardwareSpecification>();
            Recommended = recommended ?? new List<HardwareSpecification>();
        }
    }
}