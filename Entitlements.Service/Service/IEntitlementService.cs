namespace Entitlements.Service
{
    public interface IEntitlementService
    {
        Task<IList<Entitlement>> GetAllEntitlementsAsync();
    }
}