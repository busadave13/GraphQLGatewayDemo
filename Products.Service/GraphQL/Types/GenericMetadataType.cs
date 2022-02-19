using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class GenericMetadataType : ObjectType<GenericMetadata>
    {
        protected override void Configure(IObjectTypeDescriptor<GenericMetadata> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.CloudGaming);
            descriptor.Field(b => b.Inclusion).Type<InclusionType>();
            descriptor.Field(b => b.SupportedLanguages).Type<SupportedLanguagesType>();
            descriptor.Field(b => b.CompareEditions).Type<CompareEditionsType>();
            descriptor.Field(b => b.TechnicalCapabilities).Type<GenericMetadataStatusEnumType>();
            descriptor.Field(b => b.Accessibility).Type<AccessibilityType>();
        }
    }
}
