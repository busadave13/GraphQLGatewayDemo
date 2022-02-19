namespace Products.Service.Contracts
{
    public class RecurrencePolicy
    {
        public Duration Duration { get; set; }
        public Duration InitialDuration { get; set; }
        public string RecurrencePolicyId { get; set; }
        public bool HasTrial { get; set; }
        public bool IsRecurring { get; set; }
    }
}