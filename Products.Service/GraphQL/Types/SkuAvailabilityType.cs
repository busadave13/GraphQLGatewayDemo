using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class SkuAvailabilityType : ObjectType<SkuAvailability>
    {
        protected override void Configure(IObjectTypeDescriptor<SkuAvailability> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.Sku).Type<SkuType>();
            descriptor.Field(b => b.Availabilities).Type<ListType<AvailabilityType>>();
        }
    }
}
