namespace Products.Service
{
    public class Product
    {
        public Product()
        {
            Skus = new List<ProductSku>();
            Skus.Add(new ProductSku() { SkuId = 1, Name = "Premium" } );
            Skus.Add(new ProductSku() { SkuId = 2, Name = "Deluxe" });
            Skus.Add(new ProductSku() { SkuId = 1, Name = "Standard" });
        }
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IList<ProductSku> Skus { get; set; }
    }
}
