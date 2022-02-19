using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class HardwareSpecificationType : ObjectType<HardwareSpecification>
    {
        protected override void Configure(IObjectTypeDescriptor<HardwareSpecification> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.Name).Type<StringType>();
            descriptor.Field(b => b.Description).Type<StringType>();
        }
    }
}
