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

        public async Task<IList<Entitlement>> GetEntitlementsByProductIdAsync(string[] productIds, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var results = await _service.GetAllEntitlementsAsync();            
            return results.Where(m => productIds.Contains(m.ProductId)).ToList();
        }

        public async Task<Entitlement> GetEntitlementByProductIdAsync(string productId, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var results = await _service.GetAllEntitlementsAsync();
            return results.FirstOrDefault(x => x.ProductId == productId);
        }
    }
}
