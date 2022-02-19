using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class BundleProductType : ObjectType<BundleProduct>
    {
        protected override void Configure(IObjectTypeDescriptor<BundleProduct> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.Position).Type<StringType>();
            descriptor.Field(b => b.ProductId).Type<StringType>();
        }
    }
}
