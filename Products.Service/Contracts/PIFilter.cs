namespace Products.Service.Contracts
{
    public class PIFilter
    {
        public IList<string> ExclusionProperties { get; private set; }
        public IList<string> InclusionProperties { get; private set; }

        public PIFilter()
            : this(null, null)
        {
        }

        public PIFilter(IList<string> exclusionProperties = null, IList<string> inclusionProperties = null)
        {
            ExclusionProperties = exclusionProperties ?? new List<string>();
            InclusionProperties = inclusionProperties ?? new List<string>();
        }

        public PIFilter Clone() => new PIFilter(new List<string>(ExclusionProperties), new List<string>(InclusionProperties));
    }
}