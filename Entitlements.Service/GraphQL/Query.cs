namespace Entitlements.Service
{
    public class Query
    {
        private readonly IEntitlementService _service;

        public Query(IEntitlementService service)
        {
            _service = service;
        }

        [UsePaging(typeof(EntitlementType), MaxPageSize = 100, IncludeTotalCount = true)]
        [UseFiltering]
        public async Task<IList<Entitlement>> GetEntitlementsAsync(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            return await _service.GetAllEntitlementsAsync();
        }
    }
}
