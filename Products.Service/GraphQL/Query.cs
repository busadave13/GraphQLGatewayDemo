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

        //[UsePaging(typeof(ProductContractType), MaxPageSize = 100, IncludeTotalCount = true)]
        //[UseFiltering]
        public async Task<IList<ProductContract>> GetProductsByIdAsync(string[] productIds, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var results = await _service.GetAllProductsAsync();
            
            //  Where(m => productIds.Contains(m.ProductId))/
            var newlist = results.Where(m => productIds.Contains(m.ProductId)).ToList();

            return newlist;
        }

        public async Task<ProductContract> GetProductByIdAsync(string productId, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var results = await _service.GetAllProductsAsync();
            return results.FirstOrDefault(x => x.ProductId == productId);
        }
    }
}
