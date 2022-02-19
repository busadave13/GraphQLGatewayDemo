using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class NetworkType : ObjectType<Network>
    {
        protected override void Configure(IObjectTypeDescriptor<Network> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.Images).Type<ListType<ImageType>>();
            descriptor.Field(b => b.Name).Type<StringType>();
        }
    }
}
