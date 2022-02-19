using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class CapabilityType : ObjectType<Capability>
    {
        protected override void Configure(IObjectTypeDescriptor<Capability> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.Key).Type<StringType>();
            descriptor.Field(b => b.Value).Type<StringType>();
        }
    }
}
