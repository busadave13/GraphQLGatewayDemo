using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class SpecificPricesType : ObjectType<SpecificPrices>
    {
        protected override void Configure(IObjectTypeDescriptor<SpecificPrices> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.Purchaseable).Type<ListType<PriceType>>().UseFiltering();
            descriptor.Field(b => b.Giftable).Type<ListType<PriceType>>().UseFiltering();
            descriptor.Field(b => b.TotalPurchaseablePricesCount).Type<IntType>();
        }
    }
}
