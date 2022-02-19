using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class BundledSkuType : ObjectType<BundledSku>
    {
        protected override void Configure(IObjectTypeDescriptor<BundledSku> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.BigId).Type<StringType>();
        }
    }
}
