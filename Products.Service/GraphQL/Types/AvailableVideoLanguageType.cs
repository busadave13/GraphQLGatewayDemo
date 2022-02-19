using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class AvailableVideoLanguageType : ObjectType<AvailableVideoLanguage>
    {
        protected override void Configure(IObjectTypeDescriptor<AvailableVideoLanguage> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.AudioLocale).Type<StringType>();
            descriptor.Field(b => b.OverlaysProperties).Type<ListType<OverlaysPropertyType>>();
            descriptor.Field(b => b.PrimaryResolutionFormat).Type<StringType>();
            descriptor.Field(b => b.AudioLanguage).Type<StringType>();
            descriptor.Field(b => b.BurntInSubtitlesLocale).Type<StringType>();
            descriptor.Field(b => b.BurntInSubtitlesLanguage).Type<StringType>();
        }
    }
}
