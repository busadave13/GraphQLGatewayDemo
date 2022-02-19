namespace Products.Service.Contracts
{
    public class EligibilityProperties
    {
        public IList<AffirmationEP> Affirmations { get; }
        public IList<RemediationEP> Remediations { get; }

        public EligibilityProperties()
            : this(null, null)
        {
        }

        public EligibilityProperties(
            IList<AffirmationEP> affirmations = null,
            IList<RemediationEP> remediations = null)
        {
            Affirmations = affirmations ?? new List<AffirmationEP>();
            Remediations = remediations ?? new List<RemediationEP>();
        }
    }
}