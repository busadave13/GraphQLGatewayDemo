using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class RemediationEPType : ObjectType<RemediationEP>
    {
        protected override void Configure(IObjectTypeDescriptor<RemediationEP> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.RemediationId).Type<StringType>();
            descriptor.Field(b => b.Description).Type<StringType>();
        }
    }
}
