using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class VideoAttributesType : ObjectType<VideoAttributes>
    {
        protected override void Configure(IObjectTypeDescriptor<VideoAttributes> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.AvailableVideoLanguages).Type<ListType<AvailableVideoLanguageType>>();
            descriptor.Field(b => b.PrimaryResolutionFormat).Type<StringType>();
        }
    }
}
