using ProductReviews.Service;
using Products.Service.Contracts;

namespace Products.Service
{
    public class Query
    {
        private readonly IProductContractService _service;

        public Query(IProductContractService service)
        {
            _service = service;
        }

        [UsePaging(typeof(ProductContractType), MaxPageSize = 100, IncludeTotalCount = true)]
        [UseFiltering]
        public async Task<IList<ProductContract>> GetProductsAsync(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            return await _service.GetAllProductsAsync();
        }
    }
}
