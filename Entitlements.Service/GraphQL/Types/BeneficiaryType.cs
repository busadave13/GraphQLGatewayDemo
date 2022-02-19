using Entitlements.Service.Contracts;

namespace Entitlements.Service.GraphQL.Types
{
    public class BeneficiaryType : ObjectType<Beneficiary>
    {
        protected override void Configure(IObjectTypeDescriptor<Beneficiary> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.IdentityType).Type<StringType>();
            descriptor.Field(b => b.IdentityValue).Type<StringType>();
        }
    }
}
