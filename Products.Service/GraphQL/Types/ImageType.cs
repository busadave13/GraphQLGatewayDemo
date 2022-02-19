using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class ImageType : ObjectType<Image>
    {
        protected override void Configure(IObjectTypeDescriptor<Image> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.Caption).Type<StringType>();
            descriptor.Field(b => b.Height).Type<IntType>();
            descriptor.Field(b => b.ImagePurpose).Type<StringType>();
            descriptor.Field(b => b.ImagePositionInfo).Type<StringType>();
            descriptor.Field(b => b.Width).Type<IntType>();
            descriptor.Field(b => b.Uri).Type<UriType>();
            descriptor.Field(b => b.BackgroundColor).Type<StringType>();
        }
    }
}
