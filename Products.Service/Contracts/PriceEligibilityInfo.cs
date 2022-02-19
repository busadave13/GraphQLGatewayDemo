namespace Products.Service.Contracts
{
    public enum EligibilityInfoKey
    {
        None = 0,
        Affirmation = 1,
        Remediation = 2,
    }

    public class PriceEligibilityInfo
    {
        public EligibilityInfoKey Key { get; set; }
        public string BigId { get; set; }
    }
}