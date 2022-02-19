using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class EligibilityPropertiesType : ObjectType<EligibilityProperties>
    {
        protected override void Configure(IObjectTypeDescriptor<EligibilityProperties> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.Remediations).Type<ListType<RemediationEPType>>();
            descriptor.Field(b => b.Affirmations).Type<ListType<AffirmationEPType>>();
        }
    }
}
