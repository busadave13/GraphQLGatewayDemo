using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class SkuAvailabilityPriceType : ObjectType<SkuAvailabilityPrice>
    {
        protected override void Configure(IObjectTypeDescriptor<SkuAvailabilityPrice> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.ListPrice).Type<FloatType>();
            descriptor.Field(b => b.MSRP).Type<FloatType>();
            descriptor.Field(b => b.CurrencyCode).Type<StringType>();
            descriptor.Field(b => b.IsPIRequired).Type<BooleanType>();
            descriptor.Field(b => b.TaxType).Type<StringType>();
            descriptor.Field(b => b.Remediations).Type<ListType<RemediationType>>().UseFiltering();
        }
    }
}
