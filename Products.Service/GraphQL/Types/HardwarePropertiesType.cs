using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class HardwarePropertiesType : ObjectType<HardwareProperties>
    {
        protected override void Configure(IObjectTypeDescriptor<HardwareProperties> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.PlannedReleaseDate).Type<StringType>();
            descriptor.Field(b => b.DiscontinuationDate).Type<StringType>();
        }
    }
}
