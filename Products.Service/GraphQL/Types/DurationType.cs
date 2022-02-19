using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class DurationType : ObjectType<Duration>
    {
        protected override void Configure(IObjectTypeDescriptor<Duration> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.Units).Type<IntType>();
            descriptor.Field(b => b.UnitType).Type<StringType>();
        }
    }
}
