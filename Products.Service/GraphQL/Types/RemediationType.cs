using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class RemediationType : ObjectType<Remediation>
    {
        protected override void Configure(IObjectTypeDescriptor<Remediation> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.BigId).Type<StringType>();
            descriptor.Field(b => b.RemediationId).Type<StringType>();
            descriptor.Field(b => b.Type).Type<StringType>();
        }
    }
}
