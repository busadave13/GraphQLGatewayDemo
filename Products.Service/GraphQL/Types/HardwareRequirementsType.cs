using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class HardwareRequirementsType : ObjectType<HardwareRequirements>
    {
        protected override void Configure(IObjectTypeDescriptor<HardwareRequirements> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.Minimum).Type<ListType<HardwareSpecificationType>>().UseFiltering();
            descriptor.Field(b => b.Recommended).Type<ListType<HardwareSpecificationType>>().UseFiltering();
        }
    }
}
