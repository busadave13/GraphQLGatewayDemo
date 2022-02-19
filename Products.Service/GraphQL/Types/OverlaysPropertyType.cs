using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class OverlaysPropertyType : ObjectType<OverlaysProperty>
    {
        protected override void Configure(IObjectTypeDescriptor<OverlaysProperty> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.Type).Type<StringType>();
            descriptor.Field(b => b.LocaleCode).Type<StringType>();
            descriptor.Field(b => b.DisplayName).Type<StringType>();
        }
    }
}
