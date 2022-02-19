using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class SupportedLanguagesType : ObjectType<SupportedLanguages>
    {
        protected override void Configure(IObjectTypeDescriptor<SupportedLanguages> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.SubtitlesLanguageSupported);
            descriptor.Field(b => b.GamePlayAudioLanguageSupported);
            descriptor.Field(b => b.SubtitlesLanguageSupported);
            descriptor.Field(b => b.SupportedLanguageDisclaimer);
        }
    }
}
