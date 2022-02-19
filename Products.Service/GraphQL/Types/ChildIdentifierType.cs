using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class ChildIdentifierType : ObjectType<ChildIdentifier>
    {
        protected override void Configure(IObjectTypeDescriptor<ChildIdentifier> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.ProductId).Type<StringType>();
            descriptor.Field(b => b.SkuId).Type<StringType>();
            descriptor.Field(b => b.AvailabilityId).Type<StringType>();
            descriptor.Field(b => b.Tag).Type<StringType>();
            descriptor.Field(b => b.DisplayRank).Type<IntType>();
            descriptor.Field(b => b.AutoSelected).Type<BooleanType>();
            descriptor.Field(b => b.DefaultSelected).Type<BooleanType>();
        }
    }
}
