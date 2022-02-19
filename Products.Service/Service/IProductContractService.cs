using Products.Service.Contracts;

namespace ProductReviews.Service
{
    public interface IProductContractService
    {
        Task<IList<ProductContract>> GetAllProductsAsync();
    }
}