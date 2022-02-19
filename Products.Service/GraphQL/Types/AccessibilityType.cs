using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class AccessibilityType : ObjectType<Accessibility>
    {
        protected override void Configure(IObjectTypeDescriptor<Accessibility> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.Uri).Type<UriType>();
            descriptor.Field(b => b.GamePlay);
            descriptor.Field(b => b.Audio);
            descriptor.Field(b => b.Visual);
            descriptor.Field(b => b.Input);
        }
    }
}
