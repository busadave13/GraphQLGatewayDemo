namespace Products.Service.Contracts
{
    public class Remediation
    {
        public string BigId { get; set; }
        public string RemediationId { get; set; }
        public string Type { get; set; }

        public Remediation Clone() => new Remediation()
        {
            BigId = BigId,
            RemediationId = RemediationId,
            Type = Type,
        };
    }
}