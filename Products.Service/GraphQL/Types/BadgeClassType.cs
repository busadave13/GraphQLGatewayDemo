using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class BadgeClassType : ObjectType<Badge>
    {
        protected override void Configure(IObjectTypeDescriptor<Badge> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.Type).Type<BadgeTypeType>();
        }
    }
}
