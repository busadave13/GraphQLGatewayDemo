using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Products.Service;
using Products.Service.Contracts;

namespace ProductReviews.Service
{
    public class ProductContractService : IProductContractService
    {
        private IList<ProductContract> _products;

        public ProductContractService()
        {
            using (StreamReader r = new StreamReader("products.json"))
            {
                string json = r.ReadToEnd();
                _products = JsonConvert.DeserializeObject<List<ProductContract>>(json);
            }
        }

        public async Task<IList<ProductContract>> GetAllProductsAsync()
        {
            return await Task.FromResult(_products);
        }
    }
}
