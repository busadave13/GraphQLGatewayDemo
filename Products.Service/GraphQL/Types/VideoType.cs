using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class VideoType : ObjectType<Video>
    {
        protected override void Configure(IObjectTypeDescriptor<Video> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.Uri.AbsoluteUri).Type<StringType>();
            descriptor.Field(b => b.VideoPurpose).Type<StringType>();
            descriptor.Field(b => b.Height).Type<IntType>();
            descriptor.Field(b => b.Width).Type<IntType>();
            descriptor.Field(b => b.Caption).Type<StringType>();
            descriptor.Field(b => b.PreviewImage).Type<ImageType>();
            descriptor.Field(b => b.SortOrder).Type<IntType>();
        }
    }
}
