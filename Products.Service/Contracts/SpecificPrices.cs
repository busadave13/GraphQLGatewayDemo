namespace Products.Service.Contracts
{
    public class SpecificPrices
    {
        public IList<Price> Purchaseable { get; set; }
        public IList<Price> Giftable { get; set; }
        public int TotalPurchaseablePricesCount { get; set; }

        public SpecificPrices() : this(null, null) { }

        public SpecificPrices(
            IList<Price> purchaseablePrices = null,
            IList<Price> giftablePrices = null)
        {
            Purchaseable = purchaseablePrices ?? new List<Price>();
            Giftable = giftablePrices ?? new List<Price>();
            TotalPurchaseablePricesCount = Purchaseable.Count;
        }
    }
}