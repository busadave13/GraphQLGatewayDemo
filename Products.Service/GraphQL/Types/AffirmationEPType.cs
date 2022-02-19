using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class AffirmationEPType : ObjectType<AffirmationEP>
    {
        protected override void Configure(IObjectTypeDescriptor<AffirmationEP> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.Description).Type<StringType>();
            descriptor.Field(b => b.AffirmationProductId).Type<StringType>();
            descriptor.Field(b => b.AffirmationId).Type<StringType>();
        }
    }
}
