using Entitlements.Service.Contracts;

namespace Entitlements.Service
{
    public class Entitlement
    {
        public DateTime AcquiredDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsSatisfiedEntitlement { get; set; }
        public string ProductId { get; set; }
        public string ProductFamily { get; set; }
        public string SatisfiedByProductId { get; set; }
        public string ProductKind { get; set; }
        public bool AutoRenew { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsTrial { get; set; }
        public string RecurrenceSkuId { get; set; }
        public string SkuId { get; set; }
        public bool IsWithinResellerRestrictionPeriod { get; set; }
        public string RecurrenceId { get; set; }
        public string SharingSource { get; set; }
        public string EntitlementKey { get; set; }
        public string EntitlementId { get; set; }
        public string MultiStoreSource { get; set; }
        public string SandboxId { get; set; }
        public string Source { get; set; }
        public Beneficiary Beneficiary { get; set; }
        public Beneficiary Purchaser { get; set; }
    }
}
