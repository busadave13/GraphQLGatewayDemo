using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class PriceType : ObjectType<Price>
    {
        protected override void Configure(IObjectTypeDescriptor<Price> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.SkuId).Type<StringType>(); 
            descriptor.Field(b => b.AvailabilityId).Type<StringType>(); ;
            descriptor.Field(b => b.ListPrice).Type<FloatType>();
            descriptor.Field(b => b.MSRP).Type<FloatType>();
            descriptor.Field(b => b.DiscountPercentage).Type<FloatType>();
            descriptor.Field(b => b.CurrencyCode).Type<StringType>(); ;
            descriptor.Field(b => b.Remediations).Type<ListType<RemediationType>>();
            descriptor.Field(b => b.AffirmationId).Type<StringType>(); ;
            descriptor.Field(b => b.PriceEligibilityInfo).Type<PriceEligibilityInfoType>();
            descriptor.Field(b => b.AvailabilityActions).Type<ListType<StringType>>();
            descriptor.Field(b => b.EndDate).Type<DateTimeType>();
            descriptor.Field(b => b.HasXPriceOffer).Type<BooleanType>();
        }
    }
}
