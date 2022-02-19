using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class GlobalizationType : ObjectType<Globalization>
    {
        protected override void Configure(IObjectTypeDescriptor<Globalization> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.DevelopedIn).Type<StringType>();
            descriptor.Field(b => b.TechnicalNeeds);
        }
    }
}
