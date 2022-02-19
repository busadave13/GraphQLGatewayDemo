using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class PriceEligibilityInfoType : ObjectType<PriceEligibilityInfo>
    {
        protected override void Configure(IObjectTypeDescriptor<PriceEligibilityInfo> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.BigId).Type<StringType>();
            descriptor.Field(b => b.Key).Type<EligibilityInfoKeyType>();
        }
    }
}
