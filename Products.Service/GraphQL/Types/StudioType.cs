using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class StudioType : ObjectType<Studio>
    {
        protected override void Configure(IObjectTypeDescriptor<Studio> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.Images).Type<ListType<ImageType>>();
            descriptor.Field(b => b.Name).Type<StringType>();
        }
    }
}
